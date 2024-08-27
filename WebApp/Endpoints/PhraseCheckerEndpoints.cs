namespace StringManipulator.Endpoints.StringManipulator;
public static partial class StringManipulatorEndpoints
{
    public static void StringManipulatorEndpointsMap(this WebApplication app)
    {
        app.MapGet("/api/getLargestWordInPhrase", GetLargestWordInPhrase);
    }
}
