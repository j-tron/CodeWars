namespace CodeWars.Kata.Kyu6;

public class Pong(int maxScore)
{
    private bool _firstPlayersTurn;
    private int _maxScore = maxScore;
    private readonly Player _firstPlayer = new("Player 1", maxScore);
    private readonly Player _secondPlayer = new("Player 2", maxScore);

    public string Play(int ballPos, int playerPos)
    {
        _firstPlayersTurn = !_firstPlayersTurn;

        if (_maxScore == 0)
        {
            return "Game Over!";
        }

        var currentPlayer = PlayerTurn(_firstPlayersTurn);

        return HitBall(ballPos, playerPos, currentPlayer) ? Hit() : Miss();
    }

    private string Hit()
    {
        return $"{PlayerTurn(_firstPlayersTurn).Name} has hit the ball!";
    }

    private bool HitBall(int ballPos, int playerPos, Player player)
    {
        if (Math.Abs(ballPos - playerPos) < 4)
        {
            return true;
        }

        player.Score--;
        _maxScore = Math.Min(_firstPlayer.Score, _secondPlayer.Score);

        return false;
    }

    private string Miss()
    {
        var player = PlayerTurn(_firstPlayersTurn);

        return player.Score == 0
            ? $"{PlayerTurn(!_firstPlayersTurn).Name} has won the game!"
            : $"{player.Name} has missed the ball!";
    }

    private Player PlayerTurn(bool firstPlayer)
    {
        return firstPlayer ? _firstPlayer : _secondPlayer;
    }

    private record Player(string Name, int Score)
    {
        public int Score { get; set; } = Score;
    }
}

public class PongTests
{
    [Fact]
    public void Should_Hit()
    {
        var game = new Pong(2);
        Assert.Equal("Player 1 has hit the ball!", game.Play(50, 53));
    }

    [Fact]
    public void SampleTest()
    {
        var game = new Pong(2);
        Assert.Equal("Player 1 has hit the ball!", game.Play(50, 53));
        Assert.Equal("Player 2 has hit the ball!", game.Play(100, 97));
        Assert.Equal("Player 1 has missed the ball!", game.Play(0, 4));
        Assert.Equal("Player 2 has hit the ball!", game.Play(25, 25));
        Assert.Equal("Player 2 has won the game!", game.Play(75, 25));
        Assert.Equal("Game Over!", game.Play(50, 50));
    }
}