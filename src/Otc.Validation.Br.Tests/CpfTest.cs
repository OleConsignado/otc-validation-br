using Otc.Validation.Br.Library;
using System;
using System.Collections.Generic;
using Xunit;

namespace Otc.Validation.Br.Tests
{
    public class CpfTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Invalidos(string cpf)
        {
            Assert.False(CpfLibrary.Valida(cpf));
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { null },
                new object[] { "" },
                new object[] { " " },
                new object[] { "\t" },
                new object[] { "000.308.221065" },
                new object[] { "100308221-06" },
                new object[] { "00000000" },
                new object[] { "11111111" },
                new object[] { "22222222" },
                new object[] { "33333333" },
                new object[] { "44444444" },
                new object[] { "55555555" },
                new object[] { "66666666" },
                new object[] { "77777777" },
                new object[] { "88888888" },
                new object[] { "99999999" },
            };
    }
}
