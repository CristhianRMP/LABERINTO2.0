using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

public class DBMongo : MonoBehaviour
{
    private MongoClient client;
    private IMongoDatabase db;
    private IMongoCollection<BsonDocument> collection;
    // Start is called before the first frame update
    void Start()
    {
        client = new
        MongoClient("mongodb+srv://unity:unity@cluster0.jj5bi0u.mongodb.net/?retryWrites=true&w=majority");
        //Base de datos
        db = client.GetDatabase("Unity");
        collection = db.GetCollection<BsonDocument>("player");
        //Mensaje
        Debug.Log("Insertando Score");
        //Temp for testing remove;
       // GetScoresFromDataBase();
        
        
    }

}