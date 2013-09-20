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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PermissionUnmarshaller
      /// </summary>
      internal class PermissionUnmarshaller : IUnmarshaller<Permission, XmlUnmarshallerContext>, IUnmarshaller<Permission, JsonUnmarshallerContext>
      {
        Permission IUnmarshaller<Permission, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Permission Unmarshall(JsonUnmarshallerContext context)
        {
            Permission permission = new Permission();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                context.Read();
                permission.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IamUserArn", targetDepth))
              {
                context.Read();
                permission.IamUserArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AllowSsh", targetDepth))
              {
                context.Read();
                permission.AllowSsh = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AllowSudo", targetDepth))
              {
                context.Read();
                permission.AllowSudo = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return permission;
                }
            }
          

            return permission;
        }

        private static PermissionUnmarshaller instance;
        public static PermissionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PermissionUnmarshaller();
            return instance;
        }
    }
}
  
