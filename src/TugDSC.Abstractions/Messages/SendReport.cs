/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licnesed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using TugDSC.Model;

namespace TugDSC.Messages
{
    public class SendReportRequest : DscAgentRequest
    {
        public static readonly HttpMethod VERB = HttpMethod.Post;

        public const string ROUTE = "Nodes(AgentId='{AgentId}')/SendReport";
        public const string ROUTE_NAME = nameof(SendReportRequest);

        [FromBody]
        [Required(AllowEmptyStrings = true)]
        public SendReportBody Body
        { get; set; }

        public override bool HasStrictBody() => false;

        public override object GetBody() => Body;
    }
}