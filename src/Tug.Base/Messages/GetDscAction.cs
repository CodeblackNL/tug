/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licnesed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Tug.Messages.ModelBinding;
using Tug.Model;

namespace Tug.Messages
{
    public class GetDscActionRequest : DscAgentRequest
    {
        [FromBody]
        [Required]
        public GetDscActionRequestBody Body
        { get; set; } 
    }

    public class GetDscActionResponse : DscResponse
    {
        [ToResult]
        public GetDscActionResponseBody Body
        { get; set; }
    }
}