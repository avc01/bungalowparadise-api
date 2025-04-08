using bungalowparadise_api.Models.DTOs;
using bungalowparadise_api.Services.RAGServices;
using Microsoft.AspNetCore.Mvc;

namespace bungalowparadise_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartAIChatController(
        OllamaService ollama,
        ChatRagPipelineService chatRagPipeline) : ControllerBase
    {
        private readonly OllamaService _ollama = ollama;
        private readonly ChatRagPipelineService _chatRagPipeline = chatRagPipeline;

        [HttpPost]
        public async Task<IActionResult> Chat([FromBody] ChatRequestDto request)
        {
            var prompt = await _chatRagPipeline.BuildPromptAsync(request);

            var response = await _ollama.GetResponseFromOllama(prompt);

            return Ok(new { response });
        }

        [HttpPost("stream")]
        public async Task StreamChat([FromBody] ChatRequestDto request)
        {
            var prompt = await _chatRagPipeline.BuildPromptAsync(request);

            Response.ContentType = "text/plain; charset=utf-8";

            await foreach (var token in _ollama.StreamResponseFromOllama(prompt))
            {
                await Response.WriteAsync(token);
                await Response.Body.FlushAsync();
            }
        }
    }
}
