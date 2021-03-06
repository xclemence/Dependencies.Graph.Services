﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Neo4j.Driver;

namespace Dependencies.Graph.UnitTests.Models
{
    public class FakeNode : INode
    {
        public object this[string key] => Properties[key];

        public IReadOnlyList<string> Labels { get; set; } = new List<string>();

        public IReadOnlyDictionary<string, object> Properties { get; set; }

        public long Id { get; set; }

        public bool Equals([AllowNull] INode other) => throw new NotImplementedException();
    }
}
