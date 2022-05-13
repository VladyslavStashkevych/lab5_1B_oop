// VectorN.cs

namespace lab5_1B {
	public class VectorN {
		int n;
		double[] a;

		public int N {
			get => n;
			set {
				if (value >= 0) {
					n = value;
					A = new double[n];
				}
				else 
					throw new ArgumentOutOfRangeException("Size should be greater than zero!");
			}
		}
		public double[] A { get => a; set => a = value; }

		public VectorN() {
			this.N = 0;
			this.A = Array.Empty<double>();
		}
		public VectorN(int n, double[] a) {
			try {
				this.N = n;
				for(int i = 0; i< N; i++) {
					this.A[i] = a[i];
				}
			}
			catch (ArgumentOutOfRangeException ex) {
				System.Console.WriteLine(ex.ParamName);
			}
		}
		public VectorN(VectorN v) {
			try {
				this.N = v.n;
				for(int i = 0; i< N; i++) {
					this.A[i] = v.A[i];
				}
			}
			catch (ArgumentOutOfRangeException ex) {
				System.Console.WriteLine(ex.ParamName);
			}
		}

		public VectorN Add(VectorN v) => this + v;
		public VectorN Substract(VectorN v) => this - v;
		public double Scalar(VectorN v) => this * v;

		public static VectorN operator + (VectorN v1, VectorN v2) {
			try {
				VectorN result = new VectorN();
				if (v1.N != v2.N) {
					throw new ArgumentException("Vectors should have same size");
				}
				result.N = v1.N;
				for (int i = 0; i < v1.N; i++) {
					result.A[i] = v1.A[i] + v2.A[i];
				}
				return result;
			}
			catch (ArgumentException ex) {
				System.Console.WriteLine(ex.ParamName);
				return new VectorN();
			}
		}
		public static VectorN operator - (VectorN v1, VectorN v2) {
			try {
				VectorN result = new VectorN();
				if (v1.N != v2.N) {
					throw new ArgumentException("Vectors should have same size");
				}
				result.N = v1.N;
				for (int i = 0; i < v1.N; i++) {
					result.A[i] = v1.A[i] - v2.A[i];
				}
				return result;
			}
			catch (ArgumentException ex) {
				System.Console.WriteLine(ex.ParamName);
				return new VectorN();
			}
		}
		public static double operator * (VectorN v1, VectorN v2) {
			try {
				double result = 0;
				if (v1.N != v2.N) {
					throw new ArgumentException("Vectors should have same size");
				}
				for (int i = 0; i < v1.N; i++) {
					result += v1.A[i] * v2.A[i];
				}
				return result;
			}
			catch (ArgumentException ex) {
				System.Console.WriteLine(ex.ParamName);
				return 0;
			}
		}

		public VectorN PostIncrement() {
			VectorN vres = new VectorN(this.N, this.A);
			for(int i = 0; i < N; i++) {
				this.A[i]++;
			}
			return vres;
		}
		public static VectorN operator ++ (VectorN v){
			for (int i = 0; i < v.N; i++) {
				v.A[i]++;
			}
			return v;
		}
		public VectorN PostDecrement() {
			VectorN vres = new VectorN(this.N, this.A);
			for(int i = 0; i < N; i++) {
				this.A[i]--;
			}
			return vres;
		}
		public static VectorN operator -- (VectorN v) {
			for (int i = 0; i < v.N; i++) {
				v.A[i]--;
			}
			return v;
		}

		public void Read() {
			try {
                Console.Write("Enter number of elements: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    throw new ArgumentOutOfRangeException("Number of elements should be greater than zero!\nPlease, try again");
                }
                else {
                    double[] arr = new double[num];
                    for (int i = 0; i < num; i++) {
                        Console.Write($"Enter numnber {i + 1}:");
                        arr[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine();
                    this.N = num;
                    this.A = arr;
				}
			}
			catch (ArgumentOutOfRangeException ex) {
				System.Console.WriteLine(ex.ParamName);
				this.Read();
			}
		}
		public void Display() {
			Console.WriteLine(this.ToString());
		}
		public override string ToString()
				=> String.Join(" ", A.Select(c => $"{c}"));
	}
}
