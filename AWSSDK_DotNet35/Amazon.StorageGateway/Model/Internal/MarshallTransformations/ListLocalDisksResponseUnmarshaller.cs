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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for ListLocalDisks operation
      /// </summary>
      internal class ListLocalDisksResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          ListLocalDisksResponse response = new ListLocalDisksResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private void UnmarshallResult(JsonUnmarshallerContext context,ListLocalDisksResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("GatewayARN", targetDepth))
              {
                context.Read();
                response.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Disks", targetDepth))
              {
                context.Read();
                response.Disks = new List<Disk>();
                        DiskUnmarshaller unmarshaller = DiskUnmarshaller.GetInstance();
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
                   response.Disks.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
          {
            return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidGatewayRequestException"))
          {
            return new InvalidGatewayRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonStorageGatewayException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListLocalDisksResponseUnmarshaller instance;
        public static ListLocalDisksResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new ListLocalDisksResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
