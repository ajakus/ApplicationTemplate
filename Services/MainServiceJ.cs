using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainServiceJ : IMainService
{
    private IJsonService _iJsonServicej = new JsonService();
    public void Invoke()
    {
       Console.WriteLine("Read and write");
       _iJsonServicej.Write();
       //_iJsonServicej.Read();
    }
}
