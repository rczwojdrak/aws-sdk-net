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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ConnectionCostUnmarshaller
      /// </summary>
      internal class ConnectionCostUnmarshaller : IUnmarshaller<ConnectionCost, XmlUnmarshallerContext>, IUnmarshaller<ConnectionCost, JsonUnmarshallerContext>
      {
        ConnectionCost IUnmarshaller<ConnectionCost, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ConnectionCost Unmarshall(JsonUnmarshallerContext context)
        {
            ConnectionCost connectionCost = new ConnectionCost();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("name", targetDepth))
              {
                context.Read();
                connectionCost.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("unit", targetDepth))
              {
                context.Read();
                connectionCost.Unit = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("currencyCode", targetDepth))
              {
                context.Read();
                connectionCost.CurrencyCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("amount", targetDepth))
              {
                context.Read();
                connectionCost.Amount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return connectionCost;
                }
            }
          

            return connectionCost;
        }

        private static ConnectionCostUnmarshaller instance;
        public static ConnectionCostUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ConnectionCostUnmarshaller();
            return instance;
        }
    }
}
  
