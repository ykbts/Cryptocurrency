   M S B A M L   `   `   `  ����I  ECryptocurrency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Cryptocurrency.ViewsCryptocurrency.Views  5      E'clr-namespace:Cryptocurrency.ViewModelsCryptocurrency.ViewModels  5           Cryptocurrency.Views.Page3   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Cryptocurrency.Views     5      :local1'clr-namespace:Cryptocurrency.ViewModels     5        N� Title$  	CryptoApp��5
      $
��Auto��6   $
��Auto��6'    � DataContext 5      .   (Cryptocurrency.ViewModels.PriceViewModel  5   
   .��5      � -   5         �Name$ 	nextPage3��5      
������� � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6   $��2��6"   
�����w�62   �� 5   
   $��2��6   $��2��6%   $��Center=�66   $��Center=�6S   .+�5      �� -   5         ��Name$ Price��5      $��18(�6z   $��Courier New )�6�   
�������$��0,0,0,40q�6�   ��6'   �� *(&PriceInfo.Tickers[0].ConvertedLast.Usd+ �� StringFormat$ 
Price: {0}��6�   �� 5      $
��Left=�6   $��	0,-20,0,0q�64   .+�5       �� -   5        $��50��5    +   $��25��66   
���OO/�$��2q�6^   
�����w�$��Center=�5!      $��Center=�66   $��0,0,0,0q�6Q   ��5"      �� 5#      $��Center=�6$   $��Center=�6A   $��18(�6\   $	��usd��6j   
���OO/�$��Calibri)�6�   5%      �� 5'      -   5        $��50��5'   +   $��25��66   
���OO/�$��2q�6^   
�����w�$��Center=�5(      $��Center=�66   $��150,-25,0,0q�6Q   ��5)      �� 5*      $��Center=�6$   $��Center=�6A   $��18(�6\   $	��btc��6j   
���OO/�$��Calibri)�6�   5,      �� 5.      -   5        $��50��5.   +   $��25��66   
���OO/�$��2q�6^   
�����w�$��Center=�5/      $��Center=�66   $��-150,-25,0,0q�6Q   ��50      �� 51      $��Center=�6$   $��Center=�6A   $��18(�6\   $	��eth��6j   
���OO/�$��Calibri)�6�   53      54      �� 56      -   5        $ Volume��56      $��18(�6r   $��Courier New)�6�   
�������$��0,40,0,0q�6�   ��6(   �� *PriceInfo.Tickers[0].Volume+$ Volume: {0}��6�   �� 58      $��14(�6   
���OO/�$��Courier New )�6A    �� TextAlignment$
 Left=�6[   $
��Bold"�6p   $��0��59      $��0��6(   $��0,10,0,0q�65   Volume is an essential metric�� 5:   /   " in crypto trading and investment5;      �� 5=      $��0,40,0,0q�6   $��18(�6*   $��Courier New)�68   
��������� 5>      -   5         ��Name$	 Url��5>      $��Courier New)�6�   
���������6)   �� *PriceInfo.Tickers[0].TradeUrl+.�6�   .�5?      �� -   5        	 ��Name$	 Market��5?      �6+   �� *" PriceInfo.Tickers[0].Market.Name+$ Market: {0}��5@      5A      �� 5C      $��14(�6   
���OO/�$��Courier New )�6A   $
 Left=�6[   $
��Bold"�6p   $��0��5D      $��0��6(   $��0,10,0,0q�65   �� 5E      Market where it can be�� 66   " purchased(you go to the currency�� 6c   page on the market)5F      5G      �� 5I   
   $��2��6   $��2��6)   $��Center=�6:   $��Center=�6W   .+�5J      �� $,��&/Cryptocurrency;component/Images/1.png��6   $	��100��6D   �� 5K      $,��&/Cryptocurrency;component/Images/2.png��6   $	��120��6D   �� 5L      $,��&/Cryptocurrency;component/Images/3.png��6   $	��100��6D   5M      �� 5O   
   $��20(�6   
���OO/�$��Courier New )�6=   $ Right=�6W   $
��Bold"�6m   $��0��5P      $��0��6$   $��
0,74,65,10q�61   Various information�� 5Q   #   related to cryptocurrencies�� 6L   
__________5R      �� 5T   
   -	   5        $��50��5T       $��25��6+   
���OO/�$��2q�6S   
�����w�$��1��5U      $
��Left=�6   $��20,205,0,10q�69   ��5V      �� 5W      $��Center=�6   $��Center=�69   $��18(�6T   $
��home��6b   
���OO/�$��Calibri)�6�   5Y      �� 5Z   
   -
   5        $��50��5Z   %   $��25��60   
���OO/�$��2q�6X   
�������$��1��5[      $
��Left=�6   $��95,205,0,10q�69   ��5\      �� 5]      $��Center=�6   $��Center=�69   $��18(�6T   $
��back��6b   
���OO/�$��Calibri)�6�   5_       � 5a   
   -   5        
  �Name$
 Frame3��5a        � NavigationUIVisibility$ Hidden=�6    $��2��6@   $��2��6Q   5b      5c      