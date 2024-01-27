namespace DataStructures.Service;

// This class represents the functionality of HashMap object.
// HashMaps typically use arrays (of fixed length) not lists (of variable lengths) to store values.
// The Hash function is used to map a key to an index in this array.
// If more than one key is mapped ot the same index, this is known as 'Collision'.
// To avoid Collision you can implement a technique called 'Chaining'.
// Chaining is when the key-value pairs are stored in the array, not just the values.
// i.e. [[['apple', 3]], [['banana', 1], ['orange', 4]]] where banana and orange are hashed to the same index.
public class HashMap
{
    private int Size { get; set; }

    private object[,,] HashMapList { get; set; }

    private int[] IndexPositionsForChaining { get; set;}
    public HashMap(int size)
    {
        this.Size = size;
        this.HashMapList = new object[this.Size, this.Size, 2];
        this.IndexPositionsForChaining = new int[this.Size];
    }

    private int HashFunction(object key)
    {
        return Hash(key) % this.Size;
    }

    // NOTE: This is not an example of a hash function, I just implemented this as a mocked example.
    private int Hash(object key)
    {
        if (key == "apple")
        {
            return 0;
        }
        else if (key == "banana")
        {
            return 1;
        }
        else { return 1; }
    }

    public void AddKeyValuePair(object key, object value)
    {   
        int index = this.HashFunction(key);

        if (index >= this.Size)
        {
            throw new Exception("Unable to add key value pair - memory has reached maximum capacity due to collision.");
        }

        this.HashMapList[index, IndexPositionsForChaining[index], 0] = key;
        this.HashMapList[index, IndexPositionsForChaining[index], 1] = value;
        this.IndexPositionsForChaining[index] += 1;
    }

    public object GetValue(object key)
    {
        int index = this.HashFunction(key);

        for (int i = 0; i < this.Size; i++)
        {
            if (this.HashMapList[index, i, 0] == key)
            {
                return this.HashMapList[index, i, 1];
            };
        }

        throw new Exception("Key is not contained within the HashMap.");
    }

    public void DisplayHashMap()
    {
        Console.Write("\n[");
        for (int i = 0; i < this.Size;i++)
        {
            Console.Write("[");
            for (int j = 0; j < this.Size; j++)
            {
                Console.Write($"[{this.HashMapList[i, j, 0]}, {this.HashMapList[i, j, 1]}]");
            };
            Console.Write("]");
        };
        Console.Write("]\n");
    }
}
