   M S B A M L   `   `   `  ����P  LViking Rejser Eksamen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Viking_Rejser_Eksamen.ViewViking_Rejser_Eksamen.View  5   	   I)clr-namespace:Viking_Rejser_Eksamen.ModelViking_Rejser_Eksamen.Model  5   	   -    'Viking_Rejser_Eksamen.View.Tilmeldinger   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Viking_Rejser_Eksamen.View     5   	   ;Model)clr-namespace:Viking_Rejser_Eksamen.Model     5   	   -   5          � Title$  Tilmeldinger��5	   	   $	��450��6   $	��800��6+    � 	Resources 5
      <   6Viking_Rejser_Eksamen.Model.VikingRejserEksamenDataSet   vikingRejserEksamenDataSet  rejseTilmeldingerViewSource �� Source �� Source  kundeIdViewSource��%�   &	        &	      7   &	 J     7     5   
   6+   �� 5   
    6C   �� *RejseTilmeldinger+8   �� 5   
    69   �� *Kunder+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ rejseTilmeldingerDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�66   $��10,10,10,64q�6e      EnableRowVirtualization .    AutoGenerateColumns .  ��6z   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 5   7      
IsReadOnly .    Header$ Id��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6j   �� *Id+  5      -   5        	kundeNavn��$
 SizeToHeader 5   8   $ 
Kunde Navn��6M    6a   �� *Navn+  5      -   5        
rejseTitel��$
 SizeToHeader 5   9   $ 
Rejse Navn��6N    6b   �� *Navn+  5      -   5        kundeNummer��$
 SizeToHeader 5   :   $ Kunde TelefonNr��6O    6h   �� *Navn+  5      -   5        rejseBy��$
 SizeToHeader 5   6   $ Rejse By��6K    6]   �� *Navn+5      5      5      