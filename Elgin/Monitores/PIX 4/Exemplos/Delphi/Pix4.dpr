program Pix4;

uses
  Vcl.Forms,
  frmPix4 in 'frmPix4.pas' {Pix4},
  FuncoesDLL in 'FuncoesDLL.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TPix4, Pix4);
  Application.Run;
end.
