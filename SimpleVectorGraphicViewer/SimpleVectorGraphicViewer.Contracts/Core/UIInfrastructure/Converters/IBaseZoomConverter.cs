namespace SimpleVectorGraphicViewer.Contracts.Core.UIInfrastructure.Converters
{
    #region Usings
    using System.Globalization;
    #endregion

    #region IBaseZoomConverter
    /// <summary>
    /// Interface of BaseZoomConverter.
    /// </summary>
    public interface IBaseZoomConverter
    {
        object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
    #endregion
}