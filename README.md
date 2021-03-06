# mp3size for .NET Core

<p align="center" style="text-align: center; margin: auto">
	<img src="https://github.com/igorskyflyer/.net-core-mp3size/raw/master/public/mp3size.png">
	<h3 align="center">Calculates an estimated file size of Mp3 files.</h3>
</p>
<br>

> Port of <a href="https://github.com/igorskyflyer/mp3size.js">this</a>.

### Usage

`getFileSize(string time, int rate = 160): int`

> Gets the estimated size of the Mp3 file based on the audio time and bitrate.

- time: string, time the length of the Mp3 file, expects either HH:MM:ss or MM:ss format

- rate: int, the bitrate of the file, defaults to 160

returns a number, the estimated Mp3 file size or -1 in case of an error

<br>

<p align="center" style="text-align: center; margin: auto;font-style: italic;">If you like this project please consider donating to keep it alive, see <a href="#">this</a> and click on the Sponsor button at the top.</p>
