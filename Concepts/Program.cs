// See https://aka.ms/new-console-template for more information

//Array

//Test 1: Create Storage
using Concepts.Library.Datastructures.Basic;

var array = new OArray<int>(20);
//Test 2: Add Data

for (int i = 0; i <= 11; i++)
{
    array.Add(i);
}
//Test 3: Find Data
Console.WriteLine(array.Find(1));

//Test 4: Update Data
array.Update(array.Find(7), 20);



//Test 5: Delete Data
array.Delete(1);
array.Print();

