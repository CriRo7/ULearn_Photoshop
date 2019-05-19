using MyPhotoshop.Data;
using System;

namespace MyPhotoshop
{
	public class LighteningFilter : IFilter
	{
		public ParameterInfo[] GetParameters()
		{
			return new []
			{
				new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
				
			};
		}
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		
		public Photo Process(Photo original, double[] parameters)
		{
			var result=new Photo(original.width, original.height);						
			
			for (int x=0;x<result.width;x++)
				for (int y=0;y<result.height;y++)
                {                    
                    for (int z = 0; z < 3; z++)
                    {
                        var temp = result.data[x, y][z];
                        result.data[x, y][z] = Pixel.Trim(original.data[x, y][z] * parameters[0]);
                    }
                }
					
            return result;
		}

        
	}
}

