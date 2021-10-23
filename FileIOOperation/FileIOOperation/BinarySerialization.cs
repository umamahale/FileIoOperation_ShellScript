using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIOOperation
{
    class BinarySerialization
    {
        public void Serialization()
            {
                Demo sample = new Demo();
                FileStream filestream = new FileStream(@"C:\Users\om\source\repos\FileIOOperation\FileIOOperation\Example.txt\Example.txt", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(filestream, sample);
            }

            public void DeSerialization()
            {
                FileStream fileStream = new FileStream(@"C:\Users\om\source\repos\FileIOOperation\FileIOOperation\Example.txt\SerializeExample.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                Demo deserailzeSampleDemo = (Demo)formatter.Deserialize(fileStream);

                Console.WriteLine($"ApplicationName {deserailzeSampleDemo.AppilcationName} --- AppicationId {deserailzeSampleDemo.AppilcationId}");
            }


        }

        [Serializable]
        public class Demo
        {
            public string AppilcationName { get; set; } = "Binary Serialize";
            public int AppilcationId { get; set; } = 1001;
        }
    }


