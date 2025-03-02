﻿namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.Inputs.Dropdown;

public partial class _BitDropdownOptionDemo
{
    private readonly string example1RazorCode = @"
<BitDropdown Label=""Single select""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Fruits"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Apple"" Value=""@(""f-app"")"" />
    <BitDropdownOption Text=""Banana"" Value=""@(""f-ban"")"" />
    <BitDropdownOption Text=""Orange"" Value=""@(""f-org"")"" IsEnabled=""false"" />
    <BitDropdownOption Text=""Grape"" Value=""@(""f-gra"")"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Divider"" Value=""@string.Empty"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Vegetables"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Broccoli"" Value=""@(""v-bro"")"" />
    <BitDropdownOption Text=""Carrot"" Value=""@(""v-car"")"" />
    <BitDropdownOption Text=""Lettuce"" Value=""@(""v-let"")"" />
</BitDropdown>

<BitDropdown Label=""Multi select""
             Placeholder=""Select items""
             IsMultiSelect=""true"" TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""IsRequired""
             Placeholder=""Select an item""
             IsRequired=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""Disabled""
             DefaultValue=""@(""f-ora"")""
             Placeholder=""Select an item""
             IsEnabled=""false""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>";
    private readonly string example1CsharpCode = @"
private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};";

    private readonly string example2RazorCode = @"
<style>
    .custom-class {
        padding: 1rem;
        border-radius: 4px;
        background-color: midnightblue;
    }

    .custom-fruit {
        border-top: 1px solid gray;
        background-color: darkslateblue;
    }

    .custom-veg {
        font-size: 18px;
        text-decoration: overline underline line-through;
    }

    .custom-label {
        color: darkred;
        font-size: 12px;
    }

    .custom-text {
        color: darkblue;
        font-size: 16px;
    }
</style>

<BitDropdown Label=""Styled Dropdown""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string""
             Style=""padding: 1rem;border-radius: 4px;background-color: darkred;"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""Classed Dropdown""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string""
             Class=""custom-class"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>



<BitDropdown Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in styleClassItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" Style=""@item.Style"" Class=""@item.Class"" />
    }
</BitDropdown>



<BitDropdown Label=""Styles""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string""
             Styles=""@(new() { Label = ""font-size:18px;color:darkblue"", ItemText = ""color:darkred"" })"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""Classes""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string""
             Classes=""@(new() { Label = ""custom-label"", ItemText = ""custom-text"" })"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>";
    private readonly string example2CsharpCode = @"
private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};

private readonly List<BitDropdownItem<string>> styleClassItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"", Style = ""background-color:darkred"" },
    new() { Text = ""Apple"", Value = ""f-app"", Class = ""custom-fruit"" },
    new() { Text = ""Banana"", Value = ""f-ban"", Class = ""custom-fruit"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false, Class = ""custom-fruit"" },
    new() { Text = ""Grape"", Value = ""f-gra"", Class = ""custom-fruit"" },
    new() { ItemType = BitDropdownItemType.Divider, Style = ""padding:5px; background:darkgreen"" },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"", Style = ""background-color:darkblue"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"", Class = ""custom-veg"" },
    new() { Text = ""Carrot"", Value = ""v-car"", Class = ""custom-veg"" },
    new() { Text = ""Lettuce"", Value = ""v-let"", Class = ""custom-veg"" }
};";

    private readonly string example3RazorCode = @"
<BitDropdown @bind-Value=""controlledValue""
             Label=""Single select""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Fruits"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Apple"" Value=""@(""f-app"")"" />
    <BitDropdownOption Text=""Banana"" Value=""@(""f-ban"")"" />
    <BitDropdownOption Text=""Orange"" Value=""@(""f-org"")"" IsEnabled=""false"" />
    <BitDropdownOption Text=""Grape"" Value=""@(""f-gra"")"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Divider"" Value=""@string.Empty"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Vegetables"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Broccoli"" Value=""@(""v-bro"")"" />
    <BitDropdownOption Text=""Carrot"" Value=""@(""v-car"")"" />
    <BitDropdownOption Text=""Lettuce"" Value=""@(""v-let"")"" />
</BitDropdown>
<BitLabel>Selected Value: @controlledValue</BitLabel>


<BitDropdown @bind-Values=""controlledValues""
             Label=""Multi select""
             Placeholder=""Select items""
             IsMultiSelect=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>
<BitLabel>Selected Values: @string.Join("","", controlledValues)</BitLabel>";
    private readonly string example3CsharpCode = @"
private string controlledValue = ""f-app"";
private ICollection<string?> controlledValues = new[] { ""f-app"", ""f-ban"" };

private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};";

    private readonly string example4RazorCode = @"
<style>
    .custom-drp {
        gap: 10px;
        display: flex;
        align-items: center;
        flex-flow: row nowrap;
        justify-content: flex-start;
    }

    custom-drp.custom-drp-lbl {
        color: dodgerblue;
    }

    custom-drp.custom-drp-txt {
        color: goldenrod;
    }

    custom-drp.custom-drp-ph {
        color: orangered;
    }

    custom-drp.custom-drp-item {
        width: 100%;
        cursor: pointer;
    }
</style>

<BitDropdown Label=""Text & Item templates""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <TextTemplate Context=""dropdown"">
        <div class=""custom-drp custom-drp-txt"">
            <BitIcon IconName=""@((dropdown.SelectedItem?.Data as DropdownItemData)?.IconName)"" />
            <BitLabel>@dropdown.SelectedItem?.Text</BitLabel>
        </div>
    </TextTemplate>
    <ItemTemplate Context=""item"">
        <div class=""custom-drp custom-drp-item"">
            <BitIcon IconName=""@((item.Data as DropdownItemData)?.IconName)"" />
            <BitLabel Style=""text-decoration:underline"">@item.Text</BitLabel>
        </div>
    </ItemTemplate>
    <Options>
        @foreach (var item in dataItems)
        {
            <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" Data=""item.Data"" />
        }
    </Options>
</BitDropdown>

<BitDropdown Label=""Placeholder template""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <PlaceholderTemplate Context=""dropdown"">
        <div class=""custom-drp custom-drp-ph"">
            <BitIcon IconName=""@BitIconName.MessageFill"" />
            <BitLabel>@dropdown.Placeholder</BitLabel>
        </div>
    </PlaceholderTemplate>
    <Options>
        @foreach (var item in dataItems)
        {
            <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" />
        }
    </Options>
</BitDropdown>

<BitDropdown Label=""Label template""
             Placeholder=""Select an item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <LabelTemplate>
        <div class=""custom-drp custom-drp-lbl"">
            <BitLabel>Custom label</BitLabel>
            <BitIcon IconName=""@BitIconName.Info"" AriaLabel=""Info"" />
        </div>
    </LabelTemplate>
    <Options>
        @foreach (var item in dataItems)
        {
            <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" />
        }
    </Options>
</BitDropdown>

<BitDropdown Label=""CaretDownIconName""
             Placeholder=""Select an item""
             CaretDownIconName=""@BitIconName.ScrollUpDown""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in dataItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" />
    }
</BitDropdown>";
    private readonly string example4CsharpCode = @"
private readonly List<BitDropdownItem<string>> dataItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Items"" },
    new() { Text = ""Item a"", Value = ""A"", Data = new DropdownItemData { IconName = ""Memo"" } },
    new() { Text = ""Item b"", Value = ""B"", Data = new DropdownItemData { IconName = ""Print"" } },
    new() { Text = ""Item c"", Value = ""C"", Data = new DropdownItemData { IconName = ""ShoppingCart"" } },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""More Items"" },
    new() { Text = ""Item d"", Value = ""D"", Data = new DropdownItemData { IconName = ""Train"" } },
    new() { Text = ""Item e"", Value = ""E"", Data = new DropdownItemData { IconName = ""Repair"" } },
    new() { Text = ""Item f"", Value = ""F"", Data = new DropdownItemData { IconName = ""Running"" } }
};";

    private readonly string example5RazorCode = @"
<BitDropdown Label=""Responsive Dropdown""
             Placeholder=""Select an item""
             IsResponsive=true
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Fruits"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Apple"" Value=""@(""f-app"")"" />
    <BitDropdownOption Text=""Banana"" Value=""@(""f-ban"")"" />
    <BitDropdownOption Text=""Orange"" Value=""@(""f-org"")"" IsEnabled=""false"" />
    <BitDropdownOption Text=""Grape"" Value=""@(""f-gra"")"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Divider"" Value=""@string.Empty"" />
    <BitDropdownOption ItemType=""BitDropdownItemType.Header"" Text=""Vegetables"" Value=""@string.Empty"" />
    <BitDropdownOption Text=""Broccoli"" Value=""@(""f-bro"")"" />
    <BitDropdownOption Text=""Carrot"" Value=""@(""f-car"")"" />
    <BitDropdownOption Text=""Lettuce"" Value=""@(""f-let"")"" />
</BitDropdown>";
    private readonly string example5CsharpCode = @"";

    private readonly string example6RazorCode = @"
<BitDropdown Label=""Single select & auto focus""
             Placeholder=""Select an item""
             ShowSearchBox=""true""
             AutoFocusSearchBox=""true""
             SearchBoxPlaceholder=""Search item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""Multi select""
             Placeholder=""Select items""
             IsMultiSelect=""true""
             ShowSearchBox=""true""
             SearchBoxPlaceholder=""Search items""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>



<BitDropdown Label=""Single select & auto focus""
             Placeholder=""Select an item""
             ShowSearchBox=""true""
             AutoFocusSearchBox=""true""
             SearchFunction=""(items, text) => items.Where(i => i.Text?.StartsWith(text, StringComparison.OrdinalIgnoreCase) ?? false).ToArray()""
             SearchBoxPlaceholder=""Search item""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""Multi select""
             Placeholder=""Select items""
             IsMultiSelect=""true""
             ShowSearchBox=""true""
             SearchFunction=""(items, text) => items.Where(i => i.Text?.EndsWith(text, StringComparison.OrdinalIgnoreCase) ?? false).ToArray()""
             SearchBoxPlaceholder=""Search items""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>";
    private readonly string example6CsharpCode = @"
private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};";

    private readonly string example7RazorCode = @"
<BitDropdown Label=""تک انتخابی""
             Placeholder=""لطفا انتخاب کنید""
             IsRtl=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in rtlItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>

<BitDropdown Label=""چند انتخابی""
             Placeholder=""انتخاب چند گزینه ای""
             IsMultiSelect=""true""
             IsRtl=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in rtlItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>";
    private readonly string example7CsharpCode = @"
private readonly List<BitDropdownItem<string>> rtlItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""میوه ها"" },
    new() { Text = ""سیب"", Value = ""f-app"" },
    new() { Text = ""موز"", Value = ""f-ban"" },
    new() { Text = ""پرتقال"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""انگور"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""سیزیجات"" },
    new() { Text = ""کلم بروكلی"", Value = ""v-bro"" },
    new() { Text = ""هویج"", Value = ""v-car"" },
    new() { Text = ""کاهو"", Value = ""v-let"" }
};";

    private readonly string example8RazorCode = @"
<BitDropdown Label=""Auto""
             Placeholder=""Select an item""
             DropDirection=""BitDropDirection.Auto""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in dropDirectionItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" />
    }
</BitDropdown>

<BitDropdown Label=""TopAndBottom""
             Placeholder=""Select an item""
             DropDirection=""BitDropDirection.TopAndBottom""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in dropDirectionItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" />
    }
</BitDropdown>";
    private readonly string example8CsharpCode = @"
private ICollection<BitDropdownItem<string>> dropDirectionItems = default!;

protected override void OnInitialized()
{
    dropDirectionItems = Enumerable.Range(1, 15)
                                   .Select(c => new BitDropdownItem<string> { Value = c.ToString(), Text = $""Category {c}"" })
                                   .ToArray();
}";

    private readonly string example9RazorCode = @"
<BitDropdown @bind-Value=""clearValue""
             Label=""Single select dropdown""
             Placeholder=""Select an option""
             ShowClearButton=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>
<BitLabel>Value: @clearValue</BitLabel>


<BitDropdown @bind-Values=""clearValues""
             Label=""Multi select dropdown""
             Placeholder=""Select options""
             IsMultiSelect=""true""
             ShowClearButton=""true""
             TItem=""BitDropdownOption<string>"" TValue=""string"">
    @foreach (var item in basicItems)
    {
        <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
    }
</BitDropdown>
<BitLabel>Values: @string.Join(',', clearValues)</BitLabel>";
    private readonly string example9CsharpCode = @"
private string? clearValue = ""f-app"";
private ICollection<string?> clearValues = new[] { ""f-app"", ""f-ban"" };

private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};";

    private readonly string example10RazorCode = @"
@using System.ComponentModel.DataAnnotations;

<style>
    .validation-message {
        color: #A4262C;
        font-size: 0.75rem;
    }
</style>

<EditForm style=""width: 100%"" Model=""validationModel"" OnValidSubmit=""HandleValidSubmit"" OnInvalidSubmit=""HandleInvalidSubmit"">
    <DataAnnotationsValidator />

    <BitDropdown @bind-Value=""validationModel.Category""
                 Label=""Select 1 item""
                 Placeholder=""Select and item""
                 TItem=""BitDropdownOption<string>"" TValue=""string"">
        @foreach (var item in basicItems)
        {
            <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
        }
    </BitDropdown>
    <ValidationMessage For=""@(() => validationModel.Category)"" />

    <BitDropdown @bind-Values=""validationModel.Products""
                 Label=""Select min 1 and max 2 items""
                 Placeholder=""Select items""
                 IsMultiSelect=""true""
                 TItem=""BitDropdownOption<string>"" TValue=""string"">
        @foreach (var item in basicItems)
        {
            <BitDropdownOption ItemType=""item.ItemType"" Text=""@item.Text"" Value=""item.Value"" IsEnabled=""item.IsEnabled"" />
        }
    </BitDropdown>
    <ValidationMessage For=""@(() => validationModel.Products)"" />

    <BitButton ButtonType=""BitButtonType.Submit"">Submit</BitButton>
</EditForm>";
    private readonly string example10CsharpCode = @"
public class FormValidationDropdownModel
{
    [MaxLength(2, ErrorMessage = ""The property {0} have more than {1} elements"")]
    [MinLength(1, ErrorMessage = ""The property {0} doesn't have at least {1} elements"")]
    public ICollection<string?> Products { get; set; } = new List<string?>();

    [Required]
    public string Category { get; set; }
}

private FormValidationDropdownModel validationModel = new();

private async Task HandleValidSubmit() { }

private void HandleInvalidSubmit() { }

private readonly List<BitDropdownItem<string>> basicItems = new()
{
    new() { ItemType = BitDropdownItemType.Header, Text = ""Fruits"" },
    new() { Text = ""Apple"", Value = ""f-app"" },
    new() { Text = ""Banana"", Value = ""f-ban"" },
    new() { Text = ""Orange"", Value = ""f-ora"", IsEnabled = false },
    new() { Text = ""Grape"", Value = ""f-gra"" },
    new() { ItemType = BitDropdownItemType.Divider },
    new() { ItemType = BitDropdownItemType.Header, Text = ""Vegetables"" },
    new() { Text = ""Broccoli"", Value = ""v-bro"" },
    new() { Text = ""Carrot"", Value = ""v-car"" },
    new() { Text = ""Lettuce"", Value = ""v-let"" }
};";
}
