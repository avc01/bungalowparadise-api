﻿using Amazon.S3.Model;
using Amazon.S3;
using Amazon;

namespace bungalowparadise_api.Services
{
    public class S3Service
    {
        private readonly string _bucketName;
        private readonly IAmazonS3 _s3Client;

        public S3Service(IConfiguration configuration)
        {
            _bucketName = configuration["AWS:BucketName"];
            _s3Client = new AmazonS3Client(
                configuration["AWS:AccessKey"],
                configuration["AWS:SecretKey"],
                RegionEndpoint.GetBySystemName(configuration["AWS:Region"])
            );
        }

        public async Task<string> UploadFileAsync(IFormFile file, string keyPrefix)
        {
            var key = $"{keyPrefix}/{Guid.NewGuid()}_{file.FileName}";
            using var stream = file.OpenReadStream();

            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                InputStream = stream,
                ContentType = file.ContentType
            };

            await _s3Client.PutObjectAsync(request);

            return $"https://{_bucketName}.s3.amazonaws.com/{key}";
        }

        public async Task<List<string>> UploadFilesAsync(IEnumerable<IFormFile> files, string keyPrefix)
        {
            var uploadedUrls = new List<string>();

            foreach (var file in files)
            {
                var key = $"{keyPrefix}/{Guid.NewGuid()}_{file.FileName}";
                using var stream = file.OpenReadStream();

                var request = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    InputStream = stream,
                    ContentType = file.ContentType
                };

                await _s3Client.PutObjectAsync(request);
                uploadedUrls.Add($"https://{_bucketName}.s3.amazonaws.com/{key}");
            }

            return uploadedUrls;
        }

        public async Task DeleteFilesAsync(List<string> keys)
        {
            if (keys == null || keys.Count == 0)
                throw new ArgumentException("No keys provided");

            var request = new DeleteObjectsRequest
            {
                BucketName = _bucketName,
                Objects = keys.Select(k => new KeyVersion { Key = k }).ToList()
            };

            await _s3Client.DeleteObjectsAsync(request);
        }


        public async Task<Stream?> GetFileAsync(string key)
        {
            var response = await _s3Client.GetObjectAsync(_bucketName, key);
            return response.ResponseStream;
        }
    }
}
