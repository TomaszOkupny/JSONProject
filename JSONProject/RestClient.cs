using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSONProject
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string endPiont { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPiont = string.Empty;
            httpMethod = httpVerb.GET;
        }


        public string getWebContent()
        {
            string responseFromServer = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPiont);
            request.Method = httpMethod.ToString();

            HttpWebResponse response = null;

            try  
            {
                response = (HttpWebResponse)request.GetResponse();

                using(Stream dataStream = response.GetResponseStream())
                {
                    if(dataStream != null)
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            responseFromServer = reader.ReadToEnd();
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                responseFromServer = "{\"errorMessage\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

                


            return responseFromServer;
           
        }






    }
}
