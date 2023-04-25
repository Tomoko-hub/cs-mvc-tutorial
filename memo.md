1.  - cd://[fileName] (QuickMasterプロジェクトを作りたいファイルまで移動)

2.  - dotnet new mvc -o QuickMaster -f net7.0 --no-https (Create QuickMaster project)

   -o:プロジェクトの出力先（プロジェクト名）
   -f:ターゲットフレームワーク
   --no-https:httpsを無効化

   -dotnet watch:アプリを実行

-Controller,View,Model

-Model
   :Entity Framework Core (EF Core) データベースの連携に使う
   :O/R (Object/relational) mapper 一つのフィールドがプロパティに自動で割り当てられる
    -dotnet tool install --global dotnet-ef
    -dotnet tool install --global dotnet-aspnet-codegenerator
  
  #EF Core:
    1.モデルクラス（エンティティ）の定義
    2．コンテキストクラスの定義
    3．接続文字列の定義
    4.データベースの作成
    ５.アクセスのためのコードを作成