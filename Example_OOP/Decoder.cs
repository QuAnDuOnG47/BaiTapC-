public class Decoder
{
    private string Input { get; set; }
    public Decode(string input)
    {
        Input = input;
    }

    public virtualstring DecodeInput()
    {

        return Input;
    }

    virtual public void DisplayDecodedInput()
    {
        Console.WriteLine($"Decoded Input: {DecodeInput()}");
    }
}

public class Wall : Decoder
{

    public string Color { get; set; }

    public double Height { get; set; }
    public double Width { get; set; }
    public Wall(string input, string color, double height, double width) : base(input)
    {
        Color = color;
        Height = height;
        Width = width;
    }

    public void DisplayWallInfo()
    {
        Console.WriteLine($"Wall Color: {Color}, Height: {Height}, Width: {Width}");
    }
    public override void DisplayDecodedInput()
    {
        base.DisplayDecodedInput();
        Console.WriteLine($"Wall Decoded Input: {DecodeInput()}, Color: {Color}, Height: {Height}, Width: {Width}");
    }

    public override string DecodeInput()
    {
        return $"{base.DecodeInput()} - Wall";
    }
}
