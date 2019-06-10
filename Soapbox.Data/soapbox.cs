using System;
using System.Collections.Generic;
using System.Text;

namespace Soapbox.Data
{
    public class Soapbox
    {
        public int SoapboxId { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
