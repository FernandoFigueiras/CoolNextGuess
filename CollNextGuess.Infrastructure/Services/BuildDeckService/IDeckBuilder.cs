using CollNextGuess.Core.Entities;

namespace CollNextGuess.Infrastructure.Services.BuildDeckService
{
    public interface IDeckBuilder
    {
        InitialCardDeck BuildInitialDeck();
    }
}
