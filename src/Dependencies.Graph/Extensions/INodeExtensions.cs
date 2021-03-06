﻿using System.Text.Json;
using Dependencies.Graph.JsonConverters;
using Neo4j.Driver;

namespace Dependencies.Graph.Extensions
{
    internal static class INodeExtensions
    {
        internal static T To<T>(this INode node)
        {
            var serializeOptions = new JsonSerializerOptions
            {
                Converters = { new LocalDateTimeJsonConverter() }
            };

            var nodeProps = JsonSerializer.Serialize(node.Properties, serializeOptions);
            return JsonSerializer.Deserialize<T>(nodeProps);
        }
    }
}
