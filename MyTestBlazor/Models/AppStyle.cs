namespace MyTestBlazor.Models;

public class AppStyle
{
    public string Color { get; set; } = "green";
    public string Size { get; set; } = "65px";

    public List<TableListModel> TableStyle { get; set; } = new()
    {
        new TableListModel
        {
            Text = "TableDark",
            Value = "table-dark"
        },
        new TableListModel
        {
            Text = "TableStriped",
            Value = "table-striped"
        },
        new TableListModel
        {
            Text = "TableBordered",
            Value = "table-bordered"
        },
    };

    public List<string> WitcherWords { get; set; } = new()
    {
        new string("Видишь ли, эльфийская красота - она как молодое вино из Боклера. А я больше по водке"),
        new string("Ты чудесно пахнешь на этих похронах"),
        new string("Хочешь меня нахер послать? Милости просим...<<Дальше лень писать>>"),
    };
}