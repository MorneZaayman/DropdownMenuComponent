namespace DropdownMenuComponent.Components.DropdownMenu;

public class Item<Tid>
{
    public Tid? Id { get; set; }
    public string? Label { get; set; }
    public string? Url { get; set; }
    public List<Item<Tid>> Items { get; set; } = [];
}