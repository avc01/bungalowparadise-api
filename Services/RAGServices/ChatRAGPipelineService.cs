using bungalowparadise_api.Helpers;
using bungalowparadise_api.Models.DTOs;
using bungalowparadise_api.Services.RAGServices.ToolServices;

namespace bungalowparadise_api.Services.RAGServices
{
    public class ChatRagPipelineService
    {
        private readonly BookingToolService _bookingTool;
        private readonly ReviewToolService _reviewTool;
        private readonly HotelInfoToolService _hotelInfoTool;
        private readonly PromptComposer _promptComposer;

        public ChatRagPipelineService(
            BookingToolService bookingTool,
            ReviewToolService reviewTool,
            HotelInfoToolService hotelInfoTool,
            PromptComposer promptComposer)
        {
            _bookingTool = bookingTool;
            _reviewTool = reviewTool;
            _hotelInfoTool = hotelInfoTool;
            _promptComposer = promptComposer;
        }

        public async Task<string> BuildPromptAsync(ChatRequestDto request)
        {
            var messages = request.Messages.Select(m => (m.Role, m.Content)).ToList();
            var lastUserMessage = messages.LastOrDefault(m => m.Role == "user").Content ?? "";
            var intent = IntentDetector.Detect(lastUserMessage);

            string context = intent switch
            {
                UserIntent.BookingInquiry => await _bookingTool.GetBookingContextAsync(),
                UserIntent.ReviewInquiry => await _reviewTool.GetReviewsContextAsync(),
                UserIntent.HotelInfo => await _hotelInfoTool.GetHotelInfoContextAsync(),
                _ => string.Empty
            };

            return string.IsNullOrWhiteSpace(context)
                ? _promptComposer.Compose(messages)
                : _promptComposer.ComposeWithContext(context, messages);
        }
    }
}
