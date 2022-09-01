object Pix4: TPix4
  Left = 0
  Top = 0
  Caption = 'Pix4'
  ClientHeight = 491
  ClientWidth = 760
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object GroupBox1: TGroupBox
    Left = 8
    Top = 8
    Width = 737
    Height = 475
    Caption = 'Fun'#231#245'es Pix4'
    TabOrder = 0
    object Label1: TLabel
      Left = 200
      Top = 42
      Width = 26
      Height = 13
      Caption = 'Porta'
    end
    object Label3: TLabel
      Left = 200
      Top = 329
      Width = 40
      Height = 13
      Caption = 'QRCode'
    end
    object btnVersaoFirmware: TButton
      Left = 24
      Top = 80
      Width = 161
      Height = 33
      Caption = 'Vers'#227'o Firmware'
      TabOrder = 1
      OnClick = btnVersaoFirmwareClick
    end
    object btnApresentaImagem: TButton
      Left = 24
      Top = 224
      Width = 161
      Height = 33
      Caption = 'Apresenta Imagem'
      TabOrder = 4
      OnClick = btnApresentaImagemClick
    end
    object btnApresentaQRCode: TButton
      Left = 24
      Top = 320
      Width = 161
      Height = 33
      Caption = 'Apresenta QRCode'
      TabOrder = 6
      OnClick = btnApresentaQRCodeClick
    end
    object btnApresentaTextoColorido: TButton
      Left = 24
      Top = 272
      Width = 161
      Height = 33
      Caption = 'Apresenta Texto Colorido'
      TabOrder = 5
      OnClick = btnApresentaTextoColoridoClick
    end
    object btnConectar: TButton
      Left = 24
      Top = 33
      Width = 161
      Height = 33
      Caption = 'Conectar Pix4'
      TabOrder = 0
      OnClick = btnConectarClick
    end
    object btnDesconectar: TButton
      Left = 24
      Top = 128
      Width = 161
      Height = 33
      Caption = 'Desconectar Pix4'
      TabOrder = 2
      OnClick = btnDesconectarClick
    end
    object btnInicializar: TButton
      Left = 24
      Top = 176
      Width = 161
      Height = 33
      Caption = 'Inicializar Pix4'
      TabOrder = 3
      OnClick = btnInicializarClick
    end
    object memoLogs: TMemo
      Left = 392
      Top = 16
      Width = 329
      Height = 449
      Lines.Strings = (
        'memoLogs')
      TabOrder = 8
    end
    object editPorta: TEdit
      Left = 247
      Top = 39
      Width = 121
      Height = 21
      TabOrder = 9
      Text = 'COM4'
    end
    object editQrcode: TEdit
      Left = 246
      Top = 326
      Width = 121
      Height = 21
      TabOrder = 10
      Text = 'elgindevelopercommunity.github.io'
    end
    object btnReiniciaDisplay: TButton
      Left = 24
      Top = 368
      Width = 161
      Height = 33
      Caption = 'Reinicia Display'
      TabOrder = 7
      OnClick = btnReiniciaDisplayClick
    end
  end
end
