using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankSystemModel
{
    public class DepositConverter : JsonConverter<Deposit>
    {
        public override Deposit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            var jsonObject = document.RootElement;
            var depositType = jsonObject.GetProperty("DepositType").GetString();

            return depositType switch
            {
                nameof(TimeDeposit) => JsonSerializer.Deserialize<TimeDeposit>(jsonObject.GetRawText()),
                nameof(DemandDeposit) => JsonSerializer.Deserialize<DemandDeposit>(jsonObject.GetRawText()),
                _ => throw new JsonException($"Unknown deposit type: {depositType}")
            };
        }

        public override void Write(Utf8JsonWriter writer, Deposit value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }

}
