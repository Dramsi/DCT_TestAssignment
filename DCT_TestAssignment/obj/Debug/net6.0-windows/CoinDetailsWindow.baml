   M S B A M L   `   `   `  ����  DCT_TestAssignment*    $DCT_TestAssignment.CoinDetailsWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Coin details��5   	   $	��650��6   $	��750��6+    � 
ResizeMode$ NoResize=�67   .��5      �� -   5        $��
stackPanel��5      .+�5   
   �� $��	20,10,0,0q�6   $��Proper name for asset��6#   �� 5   
   -   5        $��nameTextBox��5   %   $��	20,0,20,0q�6    �� 
IsReadOnly$
 True��68   �� 5   
   $��	20,10,0,0q�6   $����Rank is in ascending order - this number is directly associated with the marketcap whereas the highest marketcap receives rank 1��6#   �� 5	   
   -   5        $��rankTextBox��5	   %   $��	20,0,20,0q�6   $
 True��68   �� 5
   
   $��	20,10,0,0q�6   $C��=Most common symbol used to identify this asset on an exchange��6#   �� 5   
   -   5        $��symbolTextBox��5   %   $��	20,0,20,0q�6   $
 True��6:   �� 5   
   $��	20,10,0,0q�6   $"��Available supply for trading��6#   �� 5   
   -   5        $��supplyTextBox��5   %   $��	20,0,20,0q�6   $
 True��6:   �� 5   
   $��	20,10,0,0q�6   $$��Total quantity of asset issued��6#   �� 5   
   -   5        $��maxSupplyTextBox��5   %   $��	20,0,20,0q�6   $
 True��6=   �� 5   
   $��	20,10,0,0q�6   $��Supply x Price��6#   �� 5   
   -   5        $��marketCapUsdTextBox��5   %   $��	20,0,20,0q�6   $
 True��6@   �� 5   
   $��	20,10,0,0q�6   $J��DQuantity of trading volume represented in USD over the last 24 hours��6#   �� 5   
   -   5        $��volumeUsd24HrTextBox��5   %   $��	20,0,20,0q�6   $
 True��6A   �� 5   
   $��	20,10,0,0q�6   $M��GVolume-weighted price based on real-time market data, translated to USD��6#   �� 5   
   -	   5        $��priceUsdTextBox��5   %   $��	20,0,20,0q�6   $
 True��6<   �� 5   
   $��	20,10,0,0q�6   $9��3The direction and value change in the last 24 hours��6#   �� 5   
   -
   5        $��changePercent24HrTextBox��5   %   $��	20,0,20,0q�6   $
 True��6E   �� 5   
   $��	20,10,0,0q�6   $8��2Volume Weighted Average Price in the last 24 hours��6#   �� 5   
   -   5        $��vwap24HrTextBox��5   %   $��	20,0,20,0q�6   $
 True��6<   �� 5   
   $��	20,10,0,0q�6   $��Official link of the coin��6#   �� 5   
   -   5        $��explorerTextBox��5   %   $��	20,0,20,0q�6   $
 True��6<   5      5      