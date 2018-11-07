using Otc.Validation.Br.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Otc.Validation.Br.Tests
{
    public class CnpjTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Invalidos(string cpnj)
        {
            Assert.False(CnpjValidation.IsValid(cpnj));
        }

        [Theory]
        [MemberData(nameof(DataValidos))]
        public void Validos(string cpnj)
        {
            Assert.True(CnpjValidation.IsValid(cpnj));
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { null },
                new object[] { "" },
                new object[] { " " },
                new object[] { "\t" },
                new object[] { "00.000.000/0000-00" },
                new object[] { "00.000.000/0000-0" },
                new object[] { "00000000000000" },
                new object[] { "11111111111111" },
                new object[] { "22222222222222" },
                new object[] { "33333333333333" },
                new object[] { "44444444444444" },
                new object[] { "55555555555555" },
                new object[] { "66666666666666" },
                new object[] { "77777777777777" },
                new object[] { "88888888888888" },
                new object[] { "99999999999999" },
            };

        public static IEnumerable<object[]> DataValidos =>
            new List<object[]>
            {
                new object[] { "24173185000102" },
                new object[] { "42822222000130" },
                new object[] { "02636194000141" }
            };
    }
}
