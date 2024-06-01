# 1_Lesson_Ferma_2D
1. Настройка камеры.
2. Расположение изображения на сцену и его настройка
3. Изменение названия добавленного объекта на сцену
4. Изменение приоритета спрайтов
5. Добавление и присвоение тега объекту на сцене
6. Добавление и настройка Rigidbody 2D
7. Добавление и настройка Box Collider 2D
8. Добавление скрипта передвижения персонажа и смены спрайта по направлению


<Window x:Class="YourNamespace.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="350" Width="525">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        
        <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="5">
            <TextBlock Text="First Name:" VerticalAlignment="Center" Margin="5"/>
            <TextBox Name="FirstNameTextBox" Width="200" Margin="5"/>
        </StackPanel>
        
        <StackPanel Grid.Row="1" Orientation="Horizontal" Margin="5">
            <TextBlock Text="Last Name:" VerticalAlignment="Center" Margin="5"/>
            <TextBox Name="LastNameTextBox" Width="200" Margin="5"/>
        </StackPanel>
        
        <StackPanel Grid.Row="2" Orientation="Horizontal" Margin="5">
            <TextBlock Text="Date of Birth:" VerticalAlignment="Center" Margin="5"/>
            <DatePicker Name="DateOfBirthPicker" Width="200" Margin="5"/>
        </StackPanel>
        
        <StackPanel Grid.Row="3" Orientation="Horizontal" Margin="5">
            <TextBlock Text="Address:" VerticalAlignment="Center" Margin="5"/>
            <TextBox Name="AddressTextBox" Width="200" Margin="5"/>
        </StackPanel>
        
        <StackPanel Grid.Row="4" Orientation="Horizontal" Margin="5">
            <TextBlock Text="Contact Info:" VerticalAlignment="Center" Margin="5"/>
            <TextBox Name="ContactInfoTextBox" Width="200" Margin="5"/>
        </StackPanel>
        
        <Button Grid.Row="5" Content="Save" Width="100" Margin="5" HorizontalAlignment="Left" Click="SaveButton_Click"/>
    </Grid>
</Window>
