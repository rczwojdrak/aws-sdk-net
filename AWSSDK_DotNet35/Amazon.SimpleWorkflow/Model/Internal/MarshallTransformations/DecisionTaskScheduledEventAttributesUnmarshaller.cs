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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DecisionTaskScheduledEventAttributesUnmarshaller
      /// </summary>
      internal class DecisionTaskScheduledEventAttributesUnmarshaller : IUnmarshaller<DecisionTaskScheduledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<DecisionTaskScheduledEventAttributes, JsonUnmarshallerContext>
      {
        DecisionTaskScheduledEventAttributes IUnmarshaller<DecisionTaskScheduledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DecisionTaskScheduledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            DecisionTaskScheduledEventAttributes decisionTaskScheduledEventAttributes = new DecisionTaskScheduledEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("taskList", targetDepth))
              {
                context.Read();
                decisionTaskScheduledEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startToCloseTimeout", targetDepth))
              {
                context.Read();
                decisionTaskScheduledEventAttributes.StartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return decisionTaskScheduledEventAttributes;
                }
            }
          

            return decisionTaskScheduledEventAttributes;
        }

        private static DecisionTaskScheduledEventAttributesUnmarshaller instance;
        public static DecisionTaskScheduledEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DecisionTaskScheduledEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
