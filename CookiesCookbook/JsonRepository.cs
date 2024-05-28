using CookiesCookbook.Models;
using System.Text.Json;

namespace CookiesCookbook;

public class JsonRepository
{
    public void WriteJson(List<Recipe> recipes, string path)
    {
        List<string> idList = new List<string>();
        for (int i = 0; i < recipes.Count; i++)
        {
            var tempIdList = new List<int>();
            foreach (var item in recipes[i].Ingredients)
            {
                tempIdList.Add(item.ID);
            }
            idList.Add(tempIdList.ToString());
        }
        string asJson = JsonSerializer.Serialize(idList);
        Console.Write(asJson);
    }
}
