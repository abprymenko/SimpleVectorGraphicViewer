namespace SimpleVectorGraphicViewer.Contracts.Services.Providers
{
    public interface IJsonConfigurations
    {
        string ? GetString(string name);
        int? GetInt(string name);
        T? GetValue<T>(string sectionName, string propertyName);
    }
}