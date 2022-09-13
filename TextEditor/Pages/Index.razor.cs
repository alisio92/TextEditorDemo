using Syncfusion.Blazor.RichTextEditor;

namespace TextEditor.Pages;

public partial class Index
{
    private SfRichTextEditor editor;

    private List<ToolbarItemModel> tools = new()
    {
        new ToolbarItemModel {Command = ToolbarCommand.Bold},
        new ToolbarItemModel {Command = ToolbarCommand.Italic},
        new ToolbarItemModel {Command = ToolbarCommand.Underline},
        new ToolbarItemModel {Command = ToolbarCommand.StrikeThrough},
        new ToolbarItemModel {Command = ToolbarCommand.FontName},
        new ToolbarItemModel {Command = ToolbarCommand.FontSize},
        new ToolbarItemModel {Command = ToolbarCommand.FontColor},
        new ToolbarItemModel {Command = ToolbarCommand.BackgroundColor},
        new ToolbarItemModel {Command = ToolbarCommand.LowerCase},
        new ToolbarItemModel {Command = ToolbarCommand.UpperCase},
        new ToolbarItemModel {Command = ToolbarCommand.Separator},
        new ToolbarItemModel {Command = ToolbarCommand.Formats},
        new ToolbarItemModel {Command = ToolbarCommand.Alignments},
        new ToolbarItemModel {Command = ToolbarCommand.NumberFormatList},
        new ToolbarItemModel {Command = ToolbarCommand.BulletFormatList},
        new ToolbarItemModel {Command = ToolbarCommand.Outdent},
        new ToolbarItemModel {Command = ToolbarCommand.Indent},
        new ToolbarItemModel {Command = ToolbarCommand.Separator},
        new ToolbarItemModel {Command = ToolbarCommand.CreateLink},
        new ToolbarItemModel {Command = ToolbarCommand.Image},
        new ToolbarItemModel {Command = ToolbarCommand.CreateTable},
        new ToolbarItemModel {Command = ToolbarCommand.Separator},
        new ToolbarItemModel {Command = ToolbarCommand.ClearFormat},
        new ToolbarItemModel {Command = ToolbarCommand.Print},
        new ToolbarItemModel {Command = ToolbarCommand.SourceCode},
        new ToolbarItemModel {Command = ToolbarCommand.FullScreen},
        new ToolbarItemModel {Command = ToolbarCommand.Separator},
        new ToolbarItemModel {Command = ToolbarCommand.Undo},
        new ToolbarItemModel {Command = ToolbarCommand.Redo}
    };

    private List<TableToolbarItemModel> tableQuickToolbarItems = new()
    {
        new TableToolbarItemModel {Command = TableToolbarCommand.TableHeader},
        new TableToolbarItemModel {Command = TableToolbarCommand.TableRows},
        new TableToolbarItemModel {Command = TableToolbarCommand.TableColumns},
        new TableToolbarItemModel {Command = TableToolbarCommand.TableCell},
        new TableToolbarItemModel {Command = TableToolbarCommand.HorizontalSeparator},
        new TableToolbarItemModel {Command = TableToolbarCommand.TableRemove},
        new TableToolbarItemModel {Command = TableToolbarCommand.BackgroundColor},
        new TableToolbarItemModel {Command = TableToolbarCommand.TableCellVerticalAlign},
        new TableToolbarItemModel {Command = TableToolbarCommand.Styles}
    };

    private List<DropDownItemModel> fontSizeItems = new()
    {
        new DropDownItemModel {Text = "28 px", Value = "28px", Command = "Font", SubCommand = "FontSize"},
        new DropDownItemModel {Text = "36 px", Value = "36px", Command = "Font", SubCommand = "FontSize"},
        new DropDownItemModel {Text = "48 px", Value = "48px", Command = "Font", SubCommand = "FontSize"},
        new DropDownItemModel {Text = "72 px", Value = "72px", Command = "Font", SubCommand = "FontSize"}
    };

    private List<DropDownItemModel> FontFamilyItems { get; set; } = new()
    {
        new DropDownItemModel() {CssClass = "e-segoe-ui", Command = "Font", SubCommand = "FontName", Text = "Segoe UI", Value = "Segoe UI"},
        new DropDownItemModel() {CssClass = "e-arial", Command = "Font", SubCommand = "FontName", Text = "Arial", Value = "Arial"},
        new DropDownItemModel() {CssClass = "e-georgia", Command = "Font", SubCommand = "FontName", Text = "Georgia", Value = "Georgia"},
        new DropDownItemModel() {CssClass = "e-impact", Command = "Font", SubCommand = "FontName", Text = "Impact", Value = "Impact"},
        new DropDownItemModel() {CssClass = "e-tahoma", Command = "Font", SubCommand = "FontName", Text = "Tahoma", Value = "Tahoma"}
    };

    private string DefaultFontFamily { get; set; } = string.Empty;
    private string DefaultFontSize { get; set; } = string.Empty;
    private string Text { get; set; } = "";

    protected override async Task OnInitializedAsync()
    {
        DefaultFontSize = "72px";
        DefaultFontFamily = "Arial";
    }
    
    private void Callback(string obj)
    {
        Text = obj;
    }
}