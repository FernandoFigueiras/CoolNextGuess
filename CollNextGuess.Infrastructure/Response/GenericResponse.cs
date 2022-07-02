namespace CollNextGuess.Infrastructure.Response
{
    public class GenericResponse
    {
        public bool IsValid { get; set; }

        public string? Message { get; set; }

        public object? Response { get; set; }
    }
}
