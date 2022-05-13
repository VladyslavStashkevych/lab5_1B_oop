using Xunit;
using lab5_1B;

namespace lab5_1B_tests {
	public class UnitTest1 {
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		public void Method_Add_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN(a.Length, a);
			VectorN v = new VectorN(f.Length, f);
			double[] res = new double[a.Length];
			for (int i = 0; i < a.Length; i++)
				res[i] = a[i] + f[i];

			// Act
			VectorN result = s + v;

			// Assert
			Assert.Equal(res, result.A);
		}
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		[InlineData(new double[] { 0, 3.1, -4 }, new double[] { 1.2, -3, 5 })]
		public void Method_Substact_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN(a.Length, a);
			VectorN v = new VectorN(f.Length, f);
			double[] res = new double[a.Length];
			for (int i = 0; i < a.Length; i++)
				res[i] = a[i] - f[i];

			// Act
			VectorN result = s - v;

			// Assert
			Assert.Equal(res, result.A);
		}
		[Theory]
		[InlineData(new double[] { 3, 2, 1 }, new double[] { 3, 2, 1 })]
		[InlineData(new double[] { 0, 3.1, -4 }, new double[] { 1.2, -3, 5 })]
		public void Method_Scalar_ReturnsCorrectValue(double[] a, double[] f) {
			// Arrange
			VectorN s = new VectorN(a.Length, a);
			VectorN v = new VectorN(f.Length, f);
			double result = 0;
			for (int i = 0; i < a.Length; i++)
				result += a[i] * f[i];

			// Act
			double actual = s * v;

			// Assert
			Assert.Equal(result, actual);
		}
	}
}