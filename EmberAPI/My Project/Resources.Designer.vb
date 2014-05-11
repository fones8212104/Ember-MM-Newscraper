﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.34014
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("EmberAPI.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property defaultgenre() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("defaultgenre", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property defaultscreen() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("defaultscreen", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property defaultsound() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("defaultsound", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        '''&lt;genres xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        '''  &lt;supported&gt;
        '''    &lt;language&gt;English&lt;/language&gt;
        '''    &lt;language&gt;Español&lt;/language&gt;
        '''    &lt;language&gt;Français&lt;/language&gt;
        '''    &lt;language&gt;German&lt;/language&gt;
        '''    &lt;language&gt;Italian&lt;/language&gt;
        '''  &lt;/supported&gt;
        '''  &lt;name searchstring=&quot;Action&quot; language=&quot;English|German|Français&quot;&gt;
        '''    &lt;icon&gt;action.jpg&lt;/icon&gt;
        '''  &lt;/name&gt;
        '''  &lt;name searchstring=&quot;Acción&quot; language=&quot;Español&quot;&gt;
        '''     [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property Genres() As String
            Get
                Return ResourceManager.GetString("Genres", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property haslanguage() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("haslanguage", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE IF NOT EXISTS Jobs
        '''(
        '''	ID INTEGER PRIMARY KEY AUTOINCREMENT,
        '''	MediaType INTEGER NOT NULL,
        '''	MediaID INTEGER NOT NULL,
        '''	LastDateAdd TEXT
        ''');
        '''
        '''CREATE TABLE IF NOT EXISTS JobsEntry
        '''(
        '''	ID INTEGER PRIMARY KEY AUTOINCREMENT,
        '''	ItemType INTEGER NOT NULL,
        '''	Message INTEGER NOT NULL,
        '''	Details INTEGER NOT NULL,
        '''	DateAdd TEXT
        '''); ähnelt.
        '''</summary>
        Friend ReadOnly Property JobsDatabaseSQL_v1() As String
            Get
                Return ResourceManager.GetString("JobsDatabaseSQL_v1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; ?&gt;
        '''&lt;Languages&gt;
        '''  &lt;Language&gt;
        '''    &lt;name&gt;Dansk&lt;/name&gt;
        '''    &lt;abbreviation&gt;da&lt;/abbreviation&gt;
        '''    &lt;id&gt;10&lt;/id&gt;
        '''  &lt;/Language&gt;
        '''  &lt;Language&gt;
        '''    &lt;name&gt;Suomeksi&lt;/name&gt;
        '''    &lt;abbreviation&gt;fi&lt;/abbreviation&gt;
        '''    &lt;id&gt;11&lt;/id&gt;
        '''  &lt;/Language&gt;
        '''  &lt;Language&gt;
        '''    &lt;name&gt;Nederlands&lt;/name&gt;
        '''    &lt;abbreviation&gt;nl&lt;/abbreviation&gt;
        '''    &lt;id&gt;13&lt;/id&gt;
        '''  &lt;/Language&gt;
        '''  &lt;Language&gt;
        '''    &lt;name&gt;Deutsch&lt;/name&gt;
        '''    &lt;abbreviation&gt;de&lt;/abbreviation&gt;
        '''    &lt;id&gt;14&lt;/id&gt;
        '''  &lt;/Language&gt;
        '''  &lt;Language&gt;
        '''    &lt;n [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property Languages_2() As String
            Get
                Return ResourceManager.GetString("Languages_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE Sets(
        '''	SetName TEXT NOT NULL PRIMARY KEY,
        '''	HasNfo BOOL NOT NULL DEFAULT False,
        '''	NfoPath TEXT,
        '''	HasPoster BOOL NOT NULL DEFAULT False,
        '''	PosterPath TEXT,
        '''	HasFanart BOOL NOT NULL DEFAULT False,
        '''	FanartPath TEXT,
        '''	HasBanner BOOL NOT NULL DEFAULT False,
        '''	BannerPath TEXT,
        '''	HasLandscape BOOL NOT NULL DEFAULT False,
        '''	LandscapePath TEXT,
        '''	HasDiscArt BOOL NOT NULL DEFAULT False,
        '''	DiscArtPath TEXT,
        '''	HasClearLogo BOOL NOT NULL DEFAULT False,
        '''	ClearLogoPath TEXT,
        '''	HasClearArt BOOL NOT NULL  [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property MediaDatabaseSQL_v1() As String
            Get
                Return ResourceManager.GetString("MediaDatabaseSQL_v1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property missing() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("missing", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE Sets(
        '''	ID INTEGER PRIMARY KEY,
        '''	SetName TEXT NOT NULL PRIMARY KEY,
        '''	HasNfo BOOL NOT NULL DEFAULT False,
        '''	NfoPath TEXT,
        '''	HasPoster BOOL NOT NULL DEFAULT False,
        '''	PosterPath TEXT,
        '''	HasFanart BOOL NOT NULL DEFAULT False,
        '''	FanartPath TEXT,
        '''	HasBanner BOOL NOT NULL DEFAULT False,
        '''	BannerPath TEXT,
        '''	HasLandscape BOOL NOT NULL DEFAULT False,
        '''	LandscapePath TEXT,
        '''	HasDiscArt BOOL NOT NULL DEFAULT False,
        '''	DiscArtPath TEXT,
        '''	HasClearLogo BOOL NOT NULL DEFAULT False,
        '''	ClearLogoPath TEXT,
        '''	 [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property MyVideosDBSQL_v2() As String
            Get
                Return ResourceManager.GetString("MyVideosDBSQL_v2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property overlay() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("overlay", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property overlay2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("overlay2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property puzzle() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("puzzle", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        '''&lt;ratings&gt;
        '''  &lt;usa&gt;
        '''    &lt;movie&gt;
        '''      &lt;name searchstring=&quot;Rated G&quot;&gt;
        '''        &lt;icon&gt;usa/mpaag.png&lt;/icon&gt;
        '''      &lt;/name&gt;
        '''      &lt;name searchstring=&quot;Rated PG&quot;&gt;
        '''        &lt;icon&gt;usa/mpaapg.png&lt;/icon&gt;
        '''      &lt;/name&gt;
        '''      &lt;name searchstring=&quot;Rated PG-13&quot;&gt;
        '''        &lt;icon&gt;usa/mpaapg13.png&lt;/icon&gt;
        '''      &lt;/name&gt;
        '''      &lt;name searchstring=&quot;Rated R&quot;&gt;
        '''        &lt;icon&gt;usa/mpaar.png&lt;/icon&gt;
        '''      &lt;/name&gt;
        '''      &lt;name searchstring=&quot;Rated NC-17&quot;&gt;
        '''        &lt;icon&gt;usa/mpaanc17.png&lt;/icon&gt; [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        '''</summary>
        Friend ReadOnly Property Ratings() As String
            Get
                Return ResourceManager.GetString("Ratings", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
