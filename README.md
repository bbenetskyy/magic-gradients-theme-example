
[Link to Demo video on YouTube](https://youtu.be/XoXFGxPwAXk)

## Solution #1 - CSS in XAML Binding

```xaml
ContentPage.Resources>
    <x:String x:Key="LightGradient">
        repeating-linear-gradient(...)
    </x:String>
    <x:String x:Key="DarkGradient">
        repeating-linear-gradient(...)
    </x:String>
</ContentPage.Resources>

<magic:GradientView>
       <magic:CssGradientSource Stylesheet="{x:AppThemeBinding Light={StaticResource LightGradient}, Dark={StaticResource DarkGradient}}"/>
</magic:GradientView>
```

### Solution #2 - CSS in Separate File - Code Behind Binding

```css
.lightGradient {
    background: repeating-linear-gradient(...);
}
.darkGradient{
    background: repeating-linear-gradient(...);
}
```

```cs
//MainPage.xaml.cs
public MainPage()
{
    InitializeComponent();
    
    Application.Current.RequestedThemeChanged += (s, a) =>
    {
        GradientView.StyleClass = new[]
        {
            a.RequestedTheme == OSAppTheme.Light
                ? "lightGradient"
                : "darkGradient"
        };
    };
}
```
