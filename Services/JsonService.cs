using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class JsonService : IJsonService
{
    
    public string Write()
    {
        Movie product = new Movie();
        product.mediaId = 455;
        product.Title = "the worms";
        

        // Install-Package Newtonsoft.Json
        string json = JsonConvert.SerializeObject(product);

        Console.WriteLine(json);

        return json;
    }

    public void Read(string json)
    {
        Movie p = JsonConvert.DeserializeObject<Movie>(json);

        Console.WriteLine(p.mediaId);
        Console.WriteLine(p.Title);
    }

}
