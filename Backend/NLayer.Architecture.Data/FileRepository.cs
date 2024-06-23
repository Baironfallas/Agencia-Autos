
using Newtonsoft.Json;

namespace NLayer.Architecture.Data;

public class FileRepository : IFileRepository
{
    public async Task<T> ReadJsonFileAsync<T>(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<T>(json);
    }

    public async Task<List<T>> ReadListJsonFileAsync<T>(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string list = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<List<T>>(list);
    }

    public Task WriteJsonFileAsync<T>(string path, T data)
    {
        throw new NotImplementedException();
    }

    //metodo para escribir un objeto en un json
    public async Task WriteJsonFile<T>(string filePath, T data)
    {
        using StreamWriter Writer = new StreamWriter(filePath);
        string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
        await Writer.WriteAsync(json);
    }
    
}


//streamreader es una clase de una libreria la cual brindira un metodo
//para leer un archivo de inicio a fin,metodo(ReadToEndAsync)

//jsonconvert es una clase de una libreria cual nos brinda metodos para convertir json en objetos y viceversa.
// T data, data es una instancia del objeto generico

//Newtonsoft.Json.Formatting.Indented esto es un funcion propia de la libreria la cual se encarga
//de escribir el json con sangria y de una manera mas clara, la otra funcion es compacta. 

//WriteAsync sirve para escribir la informacion en un archivo