Latest version of .vstemplate

<VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Project">
  <TemplateData>
    <Name>Avalonia / ReactiveUI Project Template v1.1</Name>
    <Description>A basic Avalonia / ReactiveUI project template for quick experimentation</Description>
    <ProjectType>CSharp</ProjectType>
    <SortOrder>1000</SortOrder>
    <CreateNewFolder>true</CreateNewFolder>
    <DefaultName>AvaloniaApp</DefaultName>
    <ProvideDefaultName>true</ProvideDefaultName>
    <LocationField>Enabled</LocationField>
    <EnableLocationBrowseButton>true</EnableLocationBrowseButton>
    <CreateInPlace>true</CreateInPlace>
    <Icon>__TemplateIcon.ico</Icon>
    <LanguageTag>C#</LanguageTag>
    <PlatformTag>Windows</PlatformTag>
    <PlatformTag>macOS</PlatformTag>
    <ProjectTypeTag>desktop</ProjectTypeTag>
  </TemplateData>
  <TemplateContent>
    <Project TargetFileName="AvaloniaApp.csproj" File="AvaloniaApp.csproj" ReplaceParameters="true">
      <ProjectItem ReplaceParameters="true" TargetFileName="App.xaml">App.xaml</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="App.xaml.cs">App.xaml.cs</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="FodyWeavers.xml">FodyWeavers.xml</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="MainWindow.xaml">MainWindow.xaml</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="MainWindow.xaml.cs">MainWindow.xaml.cs</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="Program.cs">Program.cs</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="ViewModel.cs">ViewModel.cs</ProjectItem>
    </Project>
  </TemplateContent>
</VSTemplate>