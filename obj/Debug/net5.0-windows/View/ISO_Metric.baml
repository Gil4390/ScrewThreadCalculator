   M S B A M L   `   `   `  ����L  HThread Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Thread_CalculatorThread_Calculator  5   	   "    Thread_Calculator.ISO_Metric   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Thread_Calculator     5   	   -   5          � Title$  
ISO_Metric��5   	   $	��800��6   $
��1000��6)   $��16(�5	   	   .��5      � .+�5   
   �� -   5         ��Name$
 cBox��5      ${�False��6@   $
��Left=�6R   $��
230,26,0,0q�6m   $	��Top=�6�   $	��120��6�   ��6!   �� *SPlist+6�   �� 5   
   -   5         ��Name$	 btn��5   2   $
��Show��6   ${�False��6    $
��Left=�6?   $��
454,48,0,0q�6Z   $	��Top=�6n   6�   �� 5   
   $��Externel��6   $��18(�6#   $
��Left=�61   $��250,184,0,0q�6L   $	��Top=�6a   �� 5   
   $��Major Diameter (d1)��6   $
��Left=�6.   $��
40,245,0,0q�6I   $	��Top=�6]    J� RenderTransformOrigin$ -0.001,0.567&�6u   �� 5   
   $
��Left=�69   $��215,245,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd1max+ �� Mode$ OneWay=�6i   �� 5   
   $��-��6   $
��Left=�6   $��272,245,0,0q�67   $	��Top=�6L   �� 5   
   $
��Left=�69   $��313,245,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd1min+$ OneWay=�6i   �� 5   
   $��Pitch Diameter (d2)��6   $
��Left=�6.   $��
40,295,0,0q�6I   $	��Top=�6]   $ -0.001,0.567&�6u   �� 5   
   $
��Left=�69   $��215,295,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd2max+$ OneWay=�6i   �� 5   
   $��-��6   $
��Left=�6   $��272,295,0,0q�67   $	��Top=�6L   �� 5   
   $
��Left=�69   $��313,295,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd2min+$ OneWay=�6i   �� 5   
   $��Minor Diameter (d3)��6   $
��Left=�6.   $��
40,340,0,0q�6I   $	��Top=�6]   $ -0.001,0.567&�6u   �� 5   
   $
��Left=�69   $��215,340,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd3max+$ OneWay=�6i   �� 5   
   $��-��6   $
��Left=�6   $��272,340,0,0q�67   $	��Top=�6L   �� 5   
   $
��Left=�69   $��313,340,0,0q�6T   $	��Top=�6i   ��6   �� *	Exd3min+$ OneWay=�6i   �� 5   
   $	��max��6   $
��Left=�6   $��220,381,0,0q�69   $	��Top=�6N   $ 0,0.425&�6f   �� 5    
   $	��min��6   $
��Left=�6   $��316,381,0,0q�69   $	��Top=�6N   $ 0,0.425&�6f   �� 5#   
   $��Internal��6   $��18(�6#   $
��Left=�61   $��250,430,0,0q�6L   $	��Top=�6a   �� 5$   
   $
��Left=�69   $��207,495,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind1max+$ OneWay=�6i   �� 5%   
   $��-��6   $
��Left=�6   $��264,495,0,0q�67   $	��Top=�6L   �� 5&   
   $
��Left=�69   $��305,495,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind1min+$ OneWay=�6i   �� 5'   
   $
��Left=�69   $��207,545,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind2max+$ OneWay=�6i   �� 5(   
   $��-��6   $
��Left=�6   $��264,545,0,0q�67   $	��Top=�6L   �� 5)   
   $
��Left=�69   $��305,545,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind2min+$ OneWay=�6i   �� 5*   
   $
��Left=�69   $��207,590,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind3max+$ OneWay=�6i   �� 5+   
   $��-��6   $
��Left=�6   $��264,590,0,0q�67   $	��Top=�6L   �� 5,   
   $
��Left=�69   $��305,590,0,0q�6T   $	��Top=�6i   ��6   �� *	Ind3min+$ OneWay=�6i   �� 5-   
   $	��max��6   $
��Left=�6   $��212,631,0,0q�69   $	��Top=�6N   $ 0,0.425&�6f   �� 5.   
   $	��min��6   $
��Left=�6   $��308,631,0,0q�69   $	��Top=�6N   $ 0,0.425&�6f   	� 5/   
   -   5         	�Name$ NormalRadioButton��5/   '   $��Normal��6   $
��Left=�6B   $��
114,30,0,0q�6]   $	��Top=�6q   6�   	� 50   
   -   5        $ CustomRadioButton��50   '   $��Custom��6   $
��Left=�6B   $��
114,80,0,0q�6]   $	��Top=�6q   6�   �� 51   
   -   5         ��Name$ 
SizeTxtBox��51   =   ${�False��6Q   $
��Left=�6c   $��
230,78,0,0q�6~    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��56��6�   ��6   �� *Size+$ OneWayToSource=�6�   �� 52   
   -   5        $ PitchTxtBox��52   >   ${�False��6S   $
��Left=�6e   $��
339,78,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��61��6�   ��6   �� *Pitch+$ OneWayToSource=�6�   �� 53   
   $��M:��6   $
��Left=�6   $��
200,73,0,0q�68   $	��Top=�6L   �� 54   
   $��P:��6   $
��Left=�6   $��
315,73,0,0q�68   $	��Top=�6L   �� 56   
   
���  ��$
��Left=�6L   $��290,112,0,0q�6g   $	��Top=�6|   ��6   �� *	ErrorText+$ OneWay=�6|   �� 58   
   $
��Left=�6   $��1��6/   $��
110,67,0,0q�6:   
���   �$	��Top=�6]   $	��309��6u   �� 5:   
   -   5        $
��Back��5:      $
��Left=�6    $��10,7,0,0q�6;   $	��Top=�6M   6e   �� 5;   
   $
��Left=�6   $��1��6/   $��116,417,0,0q�6:   
���   �$	��Top=�6^   $	��309��6v   �� 5<   
   $��Major Diameter (d1)��6   $
��Left=�6.   $��
40,495,0,0q�6I   $	��Top=�6]   $ -0.001,0.567&�6u   �� 5=   
   $��Pitch Diameter (d2)��6   $
��Left=�6.   $��
40,545,0,0q�6I   $	��Top=�6]   $ -0.001,0.567&�6u   �� 5>   
   $��Minor Diameter (d3)��6   $
��Left=�6.   $��
40,590,0,0q�6I   $	��Top=�6]   $ -0.001,0.567&�6u   5@      5A      