using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Core;
using BraintreeHttp;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;


namespace MVCManukauTech.PayPal
{
    public class PayPalClient
    {
        /**
            Set up PayPal environment with sandbox credentials.
            In production, use ProductionEnvironment.
         */
        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment("AUzeYg9DsQj963kNdJVf2r1s4-yU0IG1SzqNtfjwexrCOq4_fmAHP-OzdZZi69vyLETPLZPo0v0_jQ9t",
                "EIOzkahdVs3DHzBj3jl0P_XlYeh53o3yJDJY4ygEz_smVpdtH9H9KuAcZbMSUeZBxr11b1imxP5t0ncz");
        }

        /**
            Returns PayPalHttpClient instance to invoke PayPal APIs.
         */
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
        }

        /**
            Use this method to serialize Object to a JSON string.
        */
        public static String ObjectToJSONString(Object serializableObject)
        {
            MemoryStream memoryStream = new MemoryStream();
            var writer = JsonReaderWriterFactory.CreateJsonWriter(
                        memoryStream, Encoding.UTF8, true, true, "  ");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializableObject.GetType(), new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true });
            ser.WriteObject(writer, serializableObject);
            memoryStream.Position = 0;
            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
