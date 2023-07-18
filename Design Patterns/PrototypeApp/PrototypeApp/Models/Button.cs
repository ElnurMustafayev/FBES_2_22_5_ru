using System.Text.Json;

namespace PrototypeApp.Models;

public class Button : IPrototype<Button> /*ICloneable*/ {
    public string Content { get; set; }
    public double? FontSize { get; set; }
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }
    public double? BorderRadius { get; set; }

    public Button(string content) {
        this.Content = content;

        var json = File.ReadAllText("Assets/ButtonStyles.json");
        var buttonFromJson = JsonSerializer.Deserialize<ButtonStyles>(json);
        Thread.Sleep(1000);

        if(buttonFromJson != null) {
            this.FontSize = buttonFromJson.FontSize;
            this.BackgroundColor = buttonFromJson.BackgroundColor;
            this.ForegroundColor = buttonFromJson.ForegroundColor;
            this.BorderRadius = buttonFromJson.BorderRadius;
            Console.WriteLine("Button styles loaded from json file");
        }
    }

    private Button() {
        Console.WriteLine("Button created without json loading");
    }

    public Button Clone() {
        Button newButton = (this.MemberwiseClone() as Button)!;
        newButton.Content = string.Empty;

        return newButton;


        //var newButton = new Button();

        //newButton.FontSize = this.FontSize;
        //newButton.BackgroundColor = this.BackgroundColor;
        //newButton.ForegroundColor = this.ForegroundColor;
        //newButton.BorderRadius = this.BorderRadius;
        //newButton.Content = string.Empty;

        //return newButton;
    }

    public override string ToString() => $"{nameof(this.Content)}={this.Content}";
}