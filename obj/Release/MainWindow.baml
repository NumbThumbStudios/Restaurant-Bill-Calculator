   M S B A M L   `   `   `  ���� U  QRestaurant Bill Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Restaurant_Bill_CalculatorRestaurant_Bill_Calculator  +    %Restaurant_Bill_Calculator.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:Restaurant_Bill_Calculator       � Title$   Restaurant Bill Calculator��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF65C589��� $ 	#FF52ACFF�� � Offset$ 1Q�.���  � ColumnDefinitions �� $��20 ��� $
��1.5* ��� $	��.5* ��� $��2* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $��20 �.+��� $��1��$��3��$��1��$��1�����	#FF0F9E7A�� $��1��$��1��$��10q�$��18(�$��SemiBold"�$ ��Restaurant Bill Calculator��
��������� $��1��$��2��$��0, 10, 0, 0q�$��SemiBold"�$��Beverage��
��������� -   	 ��Name$	 beverage_ComboBox��$��1��$��3��$��0,0,0,0q����� .R��� ���� *Name+�� -   
 ��Name$
 beverage_AddButton��$��2��$��3��$��	10,0,10,0q����	#FF3BC83B���	#FF109A10$	��Add��
��������� $��1��$��4��$��0, 10, 0, 0q�$��SemiBold"�$��	Appetizer��
��������� -   $	 appetizer_ComboBox��$��1��$��5��$��0,0,0,0q����� .R��� ���� *Name+�� -   $
 appetizer_AddButton��$��2��$��5��$��	10,0,10,0q����	#FF3BC83B���	#FF109A10$	��Add��
��������� $��1��$��6��$��0, 10, 0, 0q�$��SemiBold"�$��Main Course��
��������� -   $	 mainCourse_ComboBox��$��1��$��7��$��0,0,0,0q����� .R��� ���� *Name+�� -   $
 mainCourse_AddButton��$��2��$��7��$��	10,0,10,0q����	#FF3BC83B���	#FF109A10$	��Add��
��������� $��1��$��8��$��0, 10, 0, 0q�$��SemiBold"�$��Dessert��
��������� -   $	 dessert_ComboBox��$��1��$��9��$��0,0,0,0q����� .R��� ���� *Name+�� -   $
 dessert_AddButton��$��2��$��9��$��	10,0,10,0q����	#FF3BC83B���	#FF109A10$	��Add��
��������� $��3��$��2��$��9��$��	0,10,0,40q����	#19000000$
��10,4q�
�������.��� .+��� -	    ��Name$ bill_total_item_TextBlock���� -
   $  bill_total_price_TextBlock�� �� TextAlignment$ Right=��� $��1��$��3��$��11�����	#FF1D8CBB�� -   $ sub_and_tax_TextBlock��$��3��$��10��$��Bottom=�$��
10,10,10,7q�$��	Sub-Total��
�������$��SemiBold"�$��10(��� -   $" sub_and_tax_values_TextBlock��$��3��$��10��$��Bottom=�$��
10,10,10,7q�$ Right=�$��$0��
�������$��SemiBold"�$��10(��� -   $ total_TextBlock��$��3��$��11��$��10,0,0,0q�$��SemiBold"�$��16(�$��Center=�$��
Sub-Total:��
��������� -   $ total_value_TextBlock��$��3��$��11��$��	10,0,10,0q�$��SemiBold"�$��16(�$��Center=�$��Right=�$ Right=�$��0��
��������� -   $
 clearBill_Button��$��2��$��11��$��10q�$��
Clear Bill�����	#FFFF4949���	#FF6B3333
�������