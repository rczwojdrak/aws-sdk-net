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
      /// RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller
      /// </summary>
      internal class RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
      {
        RequestCancelExternalWorkflowExecutionFailedEventAttributes IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public RequestCancelExternalWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            RequestCancelExternalWorkflowExecutionFailedEventAttributes requestCancelExternalWorkflowExecutionFailedEventAttributes = new RequestCancelExternalWorkflowExecutionFailedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("runId", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.RunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cause", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("initiatedEventId", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.InitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                context.Read();
                requestCancelExternalWorkflowExecutionFailedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return requestCancelExternalWorkflowExecutionFailedEventAttributes;
                }
            }
          

            return requestCancelExternalWorkflowExecutionFailedEventAttributes;
        }

        private static RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller instance;
        public static RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
