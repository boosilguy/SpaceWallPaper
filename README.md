<h1>Space Wall Paper (2021)</h1>
<p>직접 제작한 Wall Paper Engine.</p>

<h2>Tech Stack</h2>
<ul>
  <li>Programming Language</li>
  <ul>
    <li><img src="https://img.shields.io/badge/C Sharp-239120?style=flat-square&logo=c-sharp&logoColor=white"/></li>
  </ul>
  <li>Framework</li>
  <ul>
    <li><img src="https://img.shields.io/badge/WASAPI-239120?style=flat-square&logo=c-sharp&logoColor=white"/></li>
    <li><img src="https://img.shields.io/badge/OpenHardwareMonitor-239120?style=flat-square&logo=c-sharp&logoColor=white"/></li>
  </ul>
  <li>Toolkit</li>
  <ul>
    <li><img src="https://img.shields.io/badge/Unity-000000?style=flat-square&logo=Unity&logoColor=white"/></li>
  </ul>
</ul>

<h2>Summary</h2>
<p><b>내 우주 감성을 쫓아 만들게된 기능성 바탕화면</b> 갬성에 쫓아, 개인 PC에 우리은하를 만들기 시작했습니다. 여기에 실용적인 부분을 접목시키고자, Equalizer와 Feedback 기능을 추가하였습니다.
아직 누추하지만 기본적인 기능을 수행할 수 있는, 가능성있는 녀석입니다.</p>

<h2>Detail</h2>
<p>Wall Paper Engine을 Unity로 구현할 수 있다는 내용을 보자마자, 바로 진행한 개인 작업물입니다. VFX는 Particle로만 구성되어 있습니다.</p>
<p>Equalizer 기능을 매우 좋아합니다. 해서, Desktop에 Sound Listener 기능을 넣고자, Windows Audio Session API (WASAPI)를 활용했습니다. Unity Audio와 비슷하게, Spectrum에 접근하여 Equalizer를 구현했습니다.</p>
<p>여기에 실용성을 불어넣기 위해, OpenHardwareMonitor를 활용했습니다. GPU Temperature, Load, 그리고 CPU Load를 사용하여, Resource Feedback을 구현하였습니다.<p>

<h3>현재 내 바탕화면</h3>

![Cosmic Wallpaper Example](https://user-images.githubusercontent.com/30020288/116773516-9367d480-aa90-11eb-962f-7260d857aaf5.PNG)

<h2>Behind Story</h2>
<p>OpenHardwareMonitor를 통해, Memory와 하드 접근을 시도했으나, GPU, CPU와 다른 형식의 함수 혹은 변수를 사용하나 봅니다. 이 부분을 확인하여, 추가로 구현할 예정입니다.</p>
<p>약간의 발적화가 있는 것 같습니다. 3070이 팬을 돌립니다... 뿐만 아니라, PC Sensor에 지속적인 접근 때문에도 발적화 현상이 보이는 것 같습니다.</p>

<h2>Next Step</h2>
<ul>
  <li><p>최적화</p></li>
  <li><p>다양한 VFX 추가</p></li>
</ul>
