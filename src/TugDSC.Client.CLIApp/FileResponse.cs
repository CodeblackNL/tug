/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licensed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

namespace TugDSC.Client
{
    // TODO:  maybe we should make this a disposable and the
    // Content should be a stream (that would be cleaned up)
    // and we could provide convenience methods to get bytes,
    // etc.  -- SOMETHING TO CONSIDER...
    
    public class FileResponse
    {
        public string ChecksumAlgorithm
        { get; set; }

        public string Checksum
        { get; set; }

        public byte[] Content
        { get; set; }
    }
}