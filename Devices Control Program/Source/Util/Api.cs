using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ControlDevice.Source.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Devices_Control_Program.Source.Util
{
    class Api
    {
        public static bool SignIn(String username, String password)
        {
            HttpWebResponse httpResponse = null;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://thomi.com.vn:8080/auth");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + username + "\"," +
                                  "\"password\":\"" + password + "\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JObject jObject = JObject.Parse(result);
                    Debug.WriteLine(jObject.GetValue("message"));
                    Data.User.token = jObject.GetValue("message").ToString();
                    return true;
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    httpResponse = (HttpWebResponse)e.Response;
                    Debug.Write("Errorcode: {0}", httpResponse.StatusCode.ToString());
                    using (var stream = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        JObject jObject = JObject.Parse(result);
                        Debug.WriteLine(jObject.GetValue("errMessage").ToString());
                        throw new Exception(jObject.GetValue("errMessage").ToString());

                    }
                }
                else
                {
                    Debug.Write("Error: {0}", e.Status.ToString());
                }
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Close();                    
                }
            }
            return false;
        }

        public static bool GetListRoom()
        {
            HttpWebResponse httpResponse = null;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://thomi.com.vn:8080/room/list");               
                httpWebRequest.Method = "GET";
                httpWebRequest.Headers["Authorization"] = "Bearer " + Data.User.token;

                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Debug.WriteLine(result);                                     
                    var rooms = JsonConvert.DeserializeObject<List<Room>>(result);
                    Data.User.rooms = rooms;
                    return true;
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    httpResponse = (HttpWebResponse)e.Response;
                    Debug.Write("Errorcode: {0}", httpResponse.StatusCode.ToString());
                    using (var stream = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        JObject jObject = JObject.Parse(result);
                        Debug.WriteLine(jObject.GetValue("errMessage").ToString());
                        throw new Exception(jObject.GetValue("errMessage").ToString());
                    }
                }
                else
                {
                    Debug.Write("Error: {0}", e.Status.ToString());
                }
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Close();
                }
            }
            return false;
        }

        public static bool GetListDevice()
        {
            HttpWebResponse httpResponse = null;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://thomi.com.vn:8080/device/list");               
                httpWebRequest.Method = "GET";
                httpWebRequest.Headers["Authorization"] = "Bearer " + Data.User.token;

                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Debug.WriteLine(result);
                    var devices = JsonConvert.DeserializeObject<List<Device>>(result);                   
                    Data.User.devices = devices;                    
                    return true;
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    httpResponse = (HttpWebResponse)e.Response;
                    Debug.Write("Errorcode: {0}", httpResponse.StatusCode.ToString());
                    using (var stream = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        JObject jObject = JObject.Parse(result);
                        Debug.WriteLine(jObject.GetValue("errMessage").ToString());
                        throw new Exception(jObject.GetValue("errMessage").ToString());
                    }
                }
                else
                {
                    Debug.Write("Error: {0}", e.Status.ToString());
                }
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Close();
                }
            }
            return false;
        }

        public static bool AddRoom(String name, int icon)
        {
            HttpWebResponse httpResponse = null;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://thomi.com.vn:8080/room/add");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers["Authorization"] = "Bearer " + Data.User.token;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"name\":\"" + name + "\"," +
                                  "\"icon\":" + icon + "}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if ((int)httpResponse.StatusCode == 200) return true;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    httpResponse = (HttpWebResponse)e.Response;
                    Debug.Write("Errorcode: {0}", httpResponse.StatusCode.ToString());
                    using (var stream = e.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        JObject jObject = JObject.Parse(result);
                        Debug.WriteLine(jObject.GetValue("errMessage").ToString());
                        throw new Exception(jObject.GetValue("errMessage").ToString());

                    }
                }
                else
                {
                    Debug.Write("Error: {0}", e.Status.ToString());
                }
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Close();
                }
            }
            return false;
        }
    }
}
