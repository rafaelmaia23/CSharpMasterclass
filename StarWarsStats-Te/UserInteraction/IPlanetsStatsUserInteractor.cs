public interface IPlanetsStatsUserInteractor
{
    void Show(IEnumerable<Planet> planets);
    string? ChooseStaticticsToBeShow(IEnumerable<string> propertiesThatCanBeChosen);
    void ShowMessage(string message);
}
