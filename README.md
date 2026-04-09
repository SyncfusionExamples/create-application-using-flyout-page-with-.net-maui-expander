# create-application-using-flyout-page-with-.net-maui-expander

This sample demonstrates how to build a MAUI application that uses a FlyoutPage together with the Syncfusion Expander control (SfExpander) to create a collapsible menu inside the Flyout.

The project shows a typical master-detail layout where the Flyout (menu) is implemented as a ContentPage containing multiple `SfExpander` controls. Each expander has a Header (icon + text) and a Content section with menu items. The Detail is a simple content page wrapped in a `NavigationPage` so the app can navigate between pages while keeping the Flyout available.

To learn more about `SfExpander`, check out the official user guide topics:

- Syncfusion Expander UG: [Getting Started with Xamarin Expander (SfExpander)](https://help.syncfusion.com/xamarin/expander/getting-started
)
## Overview

Key points covered by this sample:

- How to wire up a `FlyoutPage` with a custom Flyout view (`ExpanderFlyoutMaster`) and a Detail page (`ExpanderFlyoutDetail`).
- How to use `Syncfusion.Maui.Expander.SfExpander` to provide collapsible groups inside the Flyout.
- Basic layout techniques using `Grid`, `StackLayout`, and `ScrollView` to create a responsive menu.
- An example `NavigationPage` usage to host the Detail content.


## XAML snippets (from the sample)

ExpanderFlyoutPage.xaml:

```
<FlyoutPage.Flyout>
    <pages:ExpanderFlyoutMaster/>
</FlyoutPage.Flyout>
<FlyoutPage.Detail>
    <NavigationPage>
        <x:Arguments>
            <pages:ExpanderFlyoutDetail/>
        </x:Arguments>
    </NavigationPage>
</FlyoutPage.Detail>
```

ExpanderFlyoutDetail.xaml:

```
<StackLayout Padding="10">
    <Label Text="This is a detail page."/>
</StackLayout>
```

ExpanderFlyoutMaster.xaml (menu with multiple expanders):

```
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="150"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Grid BackgroundColor="#f54291" HeightRequest="150" Padding="20" Grid.Row="0">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="70"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        <Image Source="userimage.png" HeightRequest="70" WidthRequest="70" Margin="10,10,10,10"/>
        <Label Text="John" Grid.Column="1" FontSize="Large" VerticalOptions="Center" HorizontalOptions="Start" Padding="20"/>
    </Grid>
    <ScrollView BackgroundColor="#EDF2F5" VerticalScrollBarVisibility="Always" Grid.Row="1">
        <StackLayout>
            <syncfusion:SfExpander HeaderIconPosition="End">
                <syncfusion:SfExpander.Header>
                    <Grid HeightRequest="50">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="50"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>
                        <Image Source="home.png" HeightRequest="25" WidthRequest="25" HorizontalOptions="Center" VerticalOptions="Center"/>
                        <Label Text="Home" Grid.Column="1" TextColor="#495F6E" VerticalTextAlignment="Center" />
                    </Grid>
                </syncfusion:SfExpander.Header>

                <syncfusion:SfExpander.Content>
                    <StackLayout Padding="10,10,10,10" BackgroundColor="#FFFFFF">
                        <Label HeightRequest="50" Text="Tasks" TextColor="#303030" VerticalTextAlignment="Center" />
                        <Label HeightRequest="50" Text="Settings" TextColor="#303030" VerticalTextAlignment="Center" />
                    </StackLayout>
                </syncfusion:SfExpander.Content>
            </syncfusion:SfExpander>

            <!-- Additional expanders omitted for brevity -->
        </StackLayout>
    </ScrollView>
</Grid>
```

## How it works

1. The `FlyoutPage` composes two areas: `Flyout` and `Detail`. The Flyout hosts `ExpanderFlyoutMaster`, which contains the menu UI. The Detail is a `NavigationPage` that initially navigates to `ExpanderFlyoutDetail`.

2. Each `SfExpander` has a `Header` and `Content`. The Header typically contains an icon and a label laid out with a `Grid`. Tapping the header expands or collapses the content area showing menu items.

3. Wrapping the menu items in a `ScrollView` ensures the menu is scrollable on smaller devices.

4. The sample uses simple Label elements as menu entries. In a production app you would attach tap gestures, commands, or use Buttons to trigger navigation.


## Conclusion

I hope you enjoyed learning about how to create the application using FlyoutPage with .NET MAUI Expander (SfExpander).

You can refer to our [Xamarin.Forms Expander feature tour page](https://www.syncfusion.com/xamarin-ui-controls/xamarin-expander) to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/xamarin/expander/getting-started), and how to quickly get started for configuration specifications.

For current customers, you can check out our components from the [License and Downloads](https://www.syncfusion.com/sales/ui-component-suite) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads) to check out our other controls.

If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our [support forums](https://www.syncfusion.com/forums/) or [Direct-Trac](https://support.syncfusion.com/create). We are always happy to assist you!
