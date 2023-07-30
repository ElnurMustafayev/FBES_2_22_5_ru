namespace CompositeApp.Items.Base;

public class Item : Component
{
    public string Name { get; set; }

    public override decimal Price => 0;

    public Item(string name)
    {
        Name = name;
    }

    public override string ToString() => this.Name;
}