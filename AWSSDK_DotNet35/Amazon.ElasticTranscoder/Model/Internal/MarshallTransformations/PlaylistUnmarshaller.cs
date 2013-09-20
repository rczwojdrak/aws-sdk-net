/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PlaylistUnmarshaller
      /// </summary>
      internal class PlaylistUnmarshaller : IUnmarshaller<Playlist, XmlUnmarshallerContext>, IUnmarshaller<Playlist, JsonUnmarshallerContext>
      {
        Playlist IUnmarshaller<Playlist, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Playlist Unmarshall(JsonUnmarshallerContext context)
        {
            Playlist playlist = new Playlist();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                playlist.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Format", targetDepth))
              {
                context.Read();
                playlist.Format = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("OutputKeys", targetDepth))
              {
                context.Read();
                playlist.OutputKeys = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   playlist.OutputKeys.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                context.Read();
                playlist.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusDetail", targetDepth))
              {
                context.Read();
                playlist.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return playlist;
                }
            }
          

            return playlist;
        }

        private static PlaylistUnmarshaller instance;
        public static PlaylistUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PlaylistUnmarshaller();
            return instance;
        }
    }
}
  
