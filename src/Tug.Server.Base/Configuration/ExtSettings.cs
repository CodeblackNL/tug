/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licnesed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

namespace Tug.Server.Configuration
{
    public class ExtSettings
    {
        public bool ReplaceExtAssemblies
        { get; set; }

        public string[] SearchAssemblies
        { get; set; }

        public bool ReplaceExtPaths
        { get; set; }

        public string[] SearchPaths
        { get; set; }
    }
}